﻿// This Source Code Form is subject to the terms of the Mozilla Public
// License, v. 2.0. If a copy of the MPL was not distributed with this
// file, You can obtain one at http://mozilla.org/MPL/2.0/.

using Spreads.Collections;
using Spreads.Cursors;

// ReSharper disable once CheckNamespace
namespace Spreads
{
    /// <summary>
    /// A static class that contains all extensions to ISeries interface and its implementations.
    /// </summary>
    public static partial class Series
    {
        #region Internal methods with Opt<TKey>

        internal static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedMapCursor<TKey, TValue>>> Range<TKey, TValue>(
            this SortedMap<TKey, TValue> series,
            Opt<TKey> startKey, Opt<TKey> endKey, bool startInclusive = true, bool endInclusive = true)
        {
            var rangeCursor = new RangeCursor<TKey, TValue, SortedMapCursor<TKey, TValue>>(
                series.GetEnumerator(), startKey, endKey, startInclusive, endInclusive);
            return rangeCursor.Source;
        }

        internal static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedChunkedMapCursor<TKey, TValue>>> Range<TKey, TValue>(
            this SortedChunkedMap<TKey, TValue> series,
            Opt<TKey> startKey, Opt<TKey> endKey, bool startInclusive = true, bool endInclusive = true)
        {
            var rangeCursor = new RangeCursor<TKey, TValue, SortedChunkedMapCursor<TKey, TValue>>(
                series.GetEnumerator(), startKey, endKey, startInclusive, endInclusive);
            return rangeCursor.Source;
        }

        internal static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, Cursor<TKey, TValue>>> Range<TKey, TValue>(
            this ISeries<TKey, TValue> series,
            Opt<TKey> startKey, Opt<TKey> endKey, bool startInclusive = true, bool endInclusive = true)
        {
            var rangeCursor = new RangeCursor<TKey, TValue, Cursor<TKey, TValue>>(new Cursor<TKey, TValue>(
                series.GetCursor()), startKey, endKey, startInclusive, endInclusive);
            return rangeCursor.Source;
        }

        internal static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> Range<TKey, TValue, TCursor>(
            this CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> series,
            Opt<TKey> startKey, Opt<TKey> endKey, bool startInclusive = true, bool endInclusive = true)
            where TCursor : ISpecializedCursor<TKey, TValue, TCursor>
        {
            // adjust range to efficiently nest range series, e.g. After(x).Before(y)

            var newStartKey = Opt<TKey>.LargerOrMissing(series._cursor.StartKey, startKey, series.Comparer);
            var newStartInclusive = newStartKey.Equals(startKey) ? startInclusive : series._cursor.StartInclusive;

            var newEndKey = Opt<TKey>.SmallerOrMissing(series._cursor.EndKey, endKey, series.Comparer);
            var newEndInclusive = newEndKey.Equals(endKey) ? endInclusive : series._cursor.EndInclusive;

            var rangeCursor = new RangeCursor<TKey, TValue, TCursor>(
                series._cursor._cursor, newStartKey, newEndKey, newStartInclusive, newEndInclusive);
            return rangeCursor.Source;
        }

        #endregion Internal methods with Opt<TKey>

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedMapCursor<TKey, TValue>>> Range<TKey, TValue>(
            this SortedMap<TKey, TValue> series,
            TKey startKey, TKey endKey, bool startInclusive = true, bool endInclusive = true)
        {
            // NB cast to Opt for overload resolution
            return series.Range((Opt<TKey>)startKey, endKey, startInclusive, endInclusive);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedChunkedMapCursor<TKey, TValue>>> Range<TKey, TValue>(
            this SortedChunkedMap<TKey, TValue> series,
            TKey startKey, TKey endKey, bool startInclusive = true, bool endInclusive = true)
        {
            return series.Range((Opt<TKey>)startKey, endKey, startInclusive, endInclusive);
        }

        //public static RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>>
        //    Range<TKey, TSource, TValue, TCursor>(
        //    this MapValuesSeries<TKey, TSource, TValue, TCursor> series,
        //    TKey startKey, TKey endKey, bool startInclusive = true, bool endInclusive = true)
        //    where TCursor : ISpecializedCursor<TKey, TSource, TCursor>
        //{
        //    return new RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>>(series,
        //        new Opt<TKey>(startKey), new Opt<TKey>(endKey), startInclusive, endInclusive);
        //}

        internal static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> Range<TKey, TValue, TCursor>(
            this CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> series,
            TKey startKey, TKey endKey, bool startInclusive = true, bool endInclusive = true)
            where TCursor : ISpecializedCursor<TKey, TValue, TCursor>
        {
            return series.Range((Opt<TKey>)startKey, endKey, startInclusive, endInclusive);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, Cursor<TKey, TValue>>> Range<TKey, TValue>(
            this ISeries<TKey, TValue> series,
            TKey startKey, TKey endKey, bool startInclusive = true, bool endInclusive = true)
        {
            return series.Range((Opt<TKey>)startKey, endKey, startInclusive, endInclusive);
        }

        // AFTER

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedMapCursor<TKey, TValue>>> After<TKey, TValue>(
            this SortedMap<TKey, TValue> series,
            TKey startKey, bool startInclusive = true)
        {
            return series.Range(startKey, Opt<TKey>.Missing, startInclusive, true);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedChunkedMapCursor<TKey, TValue>>> After<TKey, TValue>(
            this SortedChunkedMap<TKey, TValue> series,
            TKey startKey, bool startInclusive = true)
        {
            return series.Range(startKey, Opt<TKey>.Missing, startInclusive, true);
        }

        //public static RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>> After<TKey, TSource, TValue, TCursor>(
        //    this MapValuesSeries<TKey, TSource, TValue, TCursor> series,
        //    TKey startKey, bool startInclusive = true)
        //    where TCursor : ISpecializedCursor<TKey, TSource, TCursor>
        //{
        //    return new RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>>(series,
        //        new Opt<TKey>(startKey), Opt<TKey>.Missing, startInclusive, true);
        //}

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> After<TKey, TValue, TCursor>(
            this CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> series,
            TKey startKey, bool startInclusive = true)
            where TCursor : ISpecializedCursor<TKey, TValue, TCursor>
        {
            return series.Range(startKey, Opt<TKey>.Missing, startInclusive, true);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, Cursor<TKey, TValue>>> After<TKey, TValue>(
            this ISeries<TKey, TValue> series,
            TKey startKey, bool startInclusive = true)
        {
            return series.Range(startKey, Opt<TKey>.Missing, startInclusive, true);
        }

        // BEFORE

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedMapCursor<TKey, TValue>>> Before<TKey, TValue>(
            this SortedMap<TKey, TValue> series,
            TKey endKey, bool endInclusive = true)
        {
            return series.Range(Opt<TKey>.Missing, endKey, true, endInclusive);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, SortedChunkedMapCursor<TKey, TValue>>> Before<TKey, TValue>(
            this SortedChunkedMap<TKey, TValue> series,
            TKey endKey, bool endInclusive = true)
        {
            return series.Range(Opt<TKey>.Missing, endKey, true, endInclusive);
        }

        //public static RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>> Before<TKey, TSource, TValue, TCursor>(
        //    this MapValuesSeries<TKey, TSource, TValue, TCursor> series,
        //    TKey endKey, bool endInclusive = true)
        //    where TCursor : ISpecializedCursor<TKey, TSource, TCursor>
        //{
        //    return new RangeSeries<TKey, TValue, MapValuesSeries<TKey, TSource, TValue, TCursor>>(series,
        //        Opt<TKey>.Missing, new Opt<TKey>(endKey), true, endInclusive);
        //}

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> Before<TKey, TValue, TCursor>(
            this CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, TCursor>> series,
            TKey endKey, bool endInclusive = true)
            where TCursor : ISpecializedCursor<TKey, TValue, TCursor>
        {
            return series.Range(Opt<TKey>.Missing, endKey, true, endInclusive);
        }

        public static CursorSeries<TKey, TValue, RangeCursor<TKey, TValue, Cursor<TKey, TValue>>> Before<TKey, TValue>(
            this ISeries<TKey, TValue> series,
            TKey endKey, bool endInclusive = true)
        {
            return series.Range(Opt<TKey>.Missing, endKey, true, endInclusive);
        }
    }
}