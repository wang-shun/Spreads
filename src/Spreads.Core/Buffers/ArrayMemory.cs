﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using Spreads.Collections.Concurrent;
using Spreads.Serialization;
using Spreads.Utils;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using static Spreads.Buffers.BuffersThrowHelper;

namespace Spreads.Buffers
{
    public class ArrayMemorySliceBucket<T>
    {
        private ArrayMemory<T> _slab;
        private int _slabFreeCount;

        private readonly int _bufferLength;
        private readonly LockedObjectPool<ArrayMemorySlice<T>> _pool;

        public ArrayMemorySliceBucket(int bufferLength, int maxBufferCount)
        {
            if (!BitUtil.IsPowerOfTwo(bufferLength) || bufferLength >= Settings.SlabLength)
            {
                ThrowHelper.ThrowArgumentException("bufferLength must be a power of two max 64kb");
            }

            _bufferLength = bufferLength;
            // NOTE: allocateOnEmpty = true
            _pool = new LockedObjectPool<ArrayMemorySlice<T>>(maxBufferCount, Factory, allocateOnEmpty: true);

            _slab = ArrayMemory<T>.Create(Settings.SlabLength);
            _slabFreeCount = _slab.Length / _bufferLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ArrayMemorySlice<T> RentMemory()
        {
            return _pool.Rent();
        }

        private ArrayMemorySlice<T> Factory()
        {
            // the whole purpose is pooling of ArrayMemorySliceBucket, it's OK to lock
            lock (_pool)
            {
                if (_slabFreeCount == 0)
                {
                    // drop previous slab, it is owned by previous slices
                    // and will be returned to the pool when all slices are disposed
                    _slab = ArrayMemory<T>.Create(Settings.SlabLength);
                    _slabFreeCount = _slab.Length / _bufferLength;
                }

                var offset = _slab.Length - _slabFreeCount-- * _bufferLength;

                var slice = new ArrayMemorySlice<T>(_slab, _pool, offset, _bufferLength);
                return slice;
            }
        }
    }

    public class ArrayMemorySlice<T> : ArrayMemory<T>
    {
        [Obsolete("internal only for tests/disgnostics")]
        internal readonly ArrayMemory<T> _slab;

        private readonly LockedObjectPool<ArrayMemorySlice<T>> _slicesPool;

        public unsafe ArrayMemorySlice(ArrayMemory<T> slab, LockedObjectPool<ArrayMemorySlice<T>> slicesPool, int offset, int length)
        {
#pragma warning disable 618
            _slab = slab;
            _slab.Increment();
            _handle = GCHandle.Alloc(_slab);
#pragma warning restore 618
            _slicesPool = slicesPool;

            _pointer = _slab.Pointer;
            _offset = offset;
            _length = length;
            _array = slab._array;
            
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void Dispose(bool disposing)
        {
            if (_externallyOwned)
            {
                ThrowHelper.ThrowNotSupportedException();
            }

            var count = Counter.Count;
            if (count != 0)
            {
                if (count > 0)
                {
                    ThrowDisposingRetained<ArrayMemorySlice<T>>();
                }
                else
                {
                    ThrowDisposed<ArrayMemorySlice<T>>();
                }
            }

            // disposing == false when finilizing and detected that non pooled
            if (disposing)
            {
                if (IsPooled)
                {
                    ThrowAlienOrAlreadyPooled<OffHeapMemory<T>>();
                }

                if (_pool != null)
                {
                    IsPooled = _pool.Return(this);
                }

                if (!IsPooled)
                {
                    // detach from pool
                    _pool = null;
                    // we still could add this to the pool of free pinned slices that are backed by an existing slab
                    var pooledToFreeSlicesPool = _slicesPool.Return(this);
                    if (!pooledToFreeSlicesPool)
                    {
                        // as if finalizing
                        GC.SuppressFinalize(this);
                        Dispose(false);
                    }
                }
            }
            else
            {
                // destroy the object and release resources
                var array = Interlocked.Exchange(ref _array, null);
                if (array != null)
                {
                    ClearBeforeDispose();
                    Debug.Assert(_handle.IsAllocated);
#pragma warning disable 618
                    _slab.Decrement();
                    _handle.Free();
#pragma warning restore 618
                }
                else
                {
                    ThrowDisposed<ArrayMemory<T>>();
                }

                Debug.Assert(!_handle.IsAllocated);

                Counter.Dispose();
                AtomicCounterService.ReleaseCounter(Counter);
            }
        }
    }

    public class ArrayMemory<T> : RetainableMemory<T>
    {
        private static readonly ObjectPool<ArrayMemory<T>> ObjectPool = new ObjectPool<ArrayMemory<T>>(() => new ArrayMemory<T>(), Environment.ProcessorCount * 16);

        internal T[] _array;
        protected GCHandle _handle;
        protected bool _externallyOwned;

        internal RetainableMemoryPool<T, ArrayMemory<T>> _pool;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected ArrayMemory() : base(AtomicCounterService.AcquireCounter())
        { }

        [Obsolete("Use Array Segment, this must be removed very soon, remove static buffers completely")]
        internal T[] Array
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _array;
        }

        internal ArraySegment<T> ArraySegment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => new ArraySegment<T>(_array, _offset, _length);
        }

        /// <summary>
        /// Create <see cref="ArrayMemory{T}"/> backed by an array from shared array pool.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArrayMemory<T> Create(int minLength)
        {
            return Create(BufferPool<T>.Rent(minLength));
        }

        /// <summary>
        /// Create <see cref="ArrayMemory{T}"/> backed by the provided array.
        /// Ownership of the provided array if transafered to <see cref="ArrayMemory{T}"/> after calling
        /// this method and no other code should touch the array afterwards.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ArrayMemory<T> Create(T[] array)
        {
            return Create(array, false);
        }

        /// <summary>
        /// Create <see cref="ArrayMemory{T}"/> backed by the provided array.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static ArrayMemory<T> Create(T[] array, bool externallyOwned)
        {
            return Create(array, 0, array.Length, false);
        }

        /// <summary>
        /// Create <see cref="ArrayMemory{T}"/> backed by the provided array.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static unsafe ArrayMemory<T> Create(T[] array, int offset, int length, bool externallyOwned)
        {
            var arrayMemory = ObjectPool.Allocate();
            arrayMemory._array = array;
            arrayMemory._handle = GCHandle.Alloc(arrayMemory._array, GCHandleType.Pinned);
            arrayMemory._pointer = Unsafe.AsPointer(ref arrayMemory._array[0]);
            arrayMemory._offset = offset;
            arrayMemory._length = length;
            arrayMemory._externallyOwned = externallyOwned;
            arrayMemory.Counter = AtomicCounterService.AcquireCounter();
            return arrayMemory;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override void Dispose(bool disposing)
        {
            var count = Counter.IsValid ? Counter.Count : -1;
            if (count != 0)
            {
                if (count > 0)
                {
                    ThrowDisposingRetained<ArrayMemorySlice<T>>();
                }
                else
                {
                    ThrowDisposed<ArrayMemorySlice<T>>();
                }
            }

            // disposing == false when finilizing and detected that non pooled
            if (disposing)
            {
                if (IsPooled)
                {
                    ThrowAlienOrAlreadyPooled<OffHeapMemory<T>>();
                }

                _pool?.Return(this);

                if (!IsPooled)
                {
                    // detach from pool
                    _pool = null;
                    // as if finalizing
                    GC.SuppressFinalize(this);
                    Dispose(false);
                }
            }
            else
            {
                var array = Interlocked.Exchange(ref _array, null);
                if (array != null)
                {
                    ClearBeforeDispose();
                    Debug.Assert(_handle.IsAllocated);
                    _handle.Free();
                    _handle = default;
                    // special value that is not normally possible - to keep thread-static buffer undisposable
                    if (!_externallyOwned)
                    {
                        BufferPool<T>.Return(array, !TypeHelper<T>.IsFixedSize);
                    }
                }
                else
                {
                    ThrowDisposed<ArrayMemory<T>>();
                }

                Debug.Assert(!_handle.IsAllocated);

                // we cannot tell is this object is pooled, so we rely on finalizer
                // that will be called only if the object is not in the pool.
                // But if we tried to pool above then we called GC.SuppressFinalize(this)
                // and finalizer won't be called if the object is dropped from ObjectPool.
                ObjectPool.Free(this);
                base.Dispose(false);
                AtomicCounterService.ReleaseCounter(Counter);
                Counter = default;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        protected override bool TryGetArray(out ArraySegment<T> buffer)
        {
            if (IsDisposed) { ThrowDisposed<ArrayMemory<T>>(); }
            buffer = ArraySegment;
            return true;
        }
    }
}