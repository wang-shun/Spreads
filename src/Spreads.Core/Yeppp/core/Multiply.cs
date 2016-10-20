using System.Runtime.InteropServices;

namespace Spreads.Yeppp
{

	/// <summary>Basic arithmetic operations</summary>
	public partial class Core
	{


		/// <summary>Multiples corresponding elements in two signed 8-bit integer arrays, producing an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8sV8s_V8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, sbyte[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (sbyte* product = &productArray[productOffset])
					{
						Multiply_V8sV8s_V8s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 8-bit integer arrays, producing an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8sV8s_V16s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, short[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					fixed (short* product = &productArray[productOffset])
					{
						Multiply_V8sV8s_V16s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two unsigned 8-bit integer arrays, producing an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8uV8u_V16u(byte[] xArray, int xOffset, byte[] yArray, int yOffset, ushort[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (byte* y = &yArray[yOffset])
				{
					fixed (ushort* product = &productArray[productOffset])
					{
						Multiply_V8uV8u_V16u(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 16-bit integer arrays, producing an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16sV16s_V16s(short[] xArray, int xOffset, short[] yArray, int yOffset, short[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (short* product = &productArray[productOffset])
					{
						Multiply_V16sV16s_V16s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 16-bit integer arrays, producing an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16sV16s_V32s(short[] xArray, int xOffset, short[] yArray, int yOffset, int[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					fixed (int* product = &productArray[productOffset])
					{
						Multiply_V16sV16s_V32s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two unsigned 16-bit integer arrays, producing an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16uV16u_V32u(ushort[] xArray, int xOffset, ushort[] yArray, int yOffset, uint[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (ushort* y = &yArray[yOffset])
				{
					fixed (uint* product = &productArray[productOffset])
					{
						Multiply_V16uV16u_V32u(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 32-bit integer arrays, producing an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32sV32s_V32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (int* product = &productArray[productOffset])
					{
						Multiply_V32sV32s_V32s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 32-bit integer arrays, producing an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32sV32s_V64s(int[] xArray, int xOffset, int[] yArray, int yOffset, long[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					fixed (long* product = &productArray[productOffset])
					{
						Multiply_V32sV32s_V64s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two unsigned 32-bit integer arrays, producing an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32uV32u_V64u(uint[] xArray, int xOffset, uint[] yArray, int yOffset, ulong[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (uint* y = &yArray[yOffset])
				{
					fixed (ulong* product = &productArray[productOffset])
					{
						Multiply_V32uV32u_V64u(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two signed 64-bit integer arrays, producing an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V64sV64s_V64s(long[] xArray, int xOffset, long[] yArray, int yOffset, long[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					fixed (long* product = &productArray[productOffset])
					{
						Multiply_V64sV64s_V64s(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two single precision (32-bit) floating-point arrays, producing an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32fV32f_V32f(float[] xArray, int xOffset, float[] yArray, int yOffset, float[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					fixed (float* product = &productArray[productOffset])
					{
						Multiply_V32fV32f_V32f(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiples corresponding elements in two double precision (64-bit) floating-point arrays, producing an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray, yArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray, yArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V64fV64f_V64f(double[] xArray, int xOffset, double[] yArray, int yOffset, double[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					fixed (double* product = &productArray[productOffset])
					{
						Multiply_V64fV64f_V64f(x, y, product, length);
					}
				}
			}
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant. Produces an array of signed 8-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8sS8s_V8s(sbyte[] xArray, int xOffset, sbyte y, sbyte[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* product = &productArray[productOffset])
				{
					Multiply_V8sS8s_V8s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8sS8s_V16s(sbyte[] xArray, int xOffset, sbyte y, short[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (short* product = &productArray[productOffset])
				{
					Multiply_V8sS8s_V16s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies unsigned 8-bit integer array elements by a constant. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V8uS8u_V16u(byte[] xArray, int xOffset, byte y, ushort[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (byte* x = &xArray[xOffset])
			{
				fixed (ushort* product = &productArray[productOffset])
				{
					Multiply_V8uS8u_V16u(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16sS16s_V16s(short[] xArray, int xOffset, short y, short[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* product = &productArray[productOffset])
				{
					Multiply_V16sS16s_V16s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16sS16s_V32s(short[] xArray, int xOffset, short y, int[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (int* product = &productArray[productOffset])
				{
					Multiply_V16sS16s_V32s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies unsigned 16-bit integer array elements by a constant. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V16uS16u_V32u(ushort[] xArray, int xOffset, ushort y, uint[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (ushort* x = &xArray[xOffset])
			{
				fixed (uint* product = &productArray[productOffset])
				{
					Multiply_V16uS16u_V32u(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32sS32s_V32s(int[] xArray, int xOffset, int y, int[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* product = &productArray[productOffset])
				{
					Multiply_V32sS32s_V32s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32sS32s_V64s(int[] xArray, int xOffset, int y, long[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (long* product = &productArray[productOffset])
				{
					Multiply_V32sS32s_V64s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies unsigned 32-bit integer array elements by a constant. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32uS32u_V64u(uint[] xArray, int xOffset, uint y, ulong[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (uint* x = &xArray[xOffset])
			{
				fixed (ulong* product = &productArray[productOffset])
				{
					Multiply_V32uS32u_V64u(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies signed 64-bit integer array elements by a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V64sS64s_V64s(long[] xArray, int xOffset, long y, long[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* product = &productArray[productOffset])
				{
					Multiply_V64sS64s_V64s(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies single precision (32-bit) floating-point array elements by a constant. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V32fS32f_V32f(float[] xArray, int xOffset, float y, float[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* product = &productArray[productOffset])
				{
					Multiply_V32fS32f_V32f(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies double precision (64-bit) floating-point array elements by a constant. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or productArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or productArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, productOffset is negative, productOffset + length exceeds the length of productArray, or length is negative.</exception>
		public static unsafe void Multiply_V64fS64f_V64f(double[] xArray, int xOffset, double y, double[] productArray, int productOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (productOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (productOffset + length > productArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* product = &productArray[productOffset])
				{
					Multiply_V64fS64f_V64f(x, y, product, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV8sV8s_IV8s(sbyte[] xArray, int xOffset, sbyte[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				fixed (sbyte* y = &yArray[yOffset])
				{
					Multiply_IV8sV8s_IV8s(x, y, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV16sV16s_IV16s(short[] xArray, int xOffset, short[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				fixed (short* y = &yArray[yOffset])
				{
					Multiply_IV16sV16s_IV16s(x, y, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV32sV32s_IV32s(int[] xArray, int xOffset, int[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				fixed (int* y = &yArray[yOffset])
				{
					Multiply_IV32sV32s_IV32s(x, y, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV64sV64s_IV64s(long[] xArray, int xOffset, long[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				fixed (long* y = &yArray[yOffset])
				{
					Multiply_IV64sV64s_IV64s(x, y, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV32fV32f_IV32f(float[] xArray, int xOffset, float[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				fixed (float* y = &yArray[yOffset])
				{
					Multiply_IV32fV32f_IV32f(x, y, length);
				}
			}
		}


		/// <summary>Multiplies corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, or length is negative.</exception>
		public static unsafe void Multiply_IV64fV64f_IV64f(double[] xArray, int xOffset, double[] yArray, int yOffset, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				fixed (double* y = &yArray[yOffset])
				{
					Multiply_IV64fV64f_IV64f(x, y, length);
				}
			}
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV8sS8s_IV8s(sbyte[] xArray, int xOffset, sbyte y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (sbyte* x = &xArray[xOffset])
			{
				Multiply_IV8sS8s_IV8s(x, y, length);
			}
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV16sS16s_IV16s(short[] xArray, int xOffset, short y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (short* x = &xArray[xOffset])
			{
				Multiply_IV16sS16s_IV16s(x, y, length);
			}
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV32sS32s_IV32s(int[] xArray, int xOffset, int y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (int* x = &xArray[xOffset])
			{
				Multiply_IV32sS32s_IV32s(x, y, length);
			}
		}


		/// <summary>Multiplies signed 64-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV64sS64s_IV64s(long[] xArray, int xOffset, long y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (long* x = &xArray[xOffset])
			{
				Multiply_IV64sS64s_IV64s(x, y, length);
			}
		}


		/// <summary>Multiplies single precision (32-bit) floating-point array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV32fS32f_IV32f(float[] xArray, int xOffset, float y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* x = &xArray[xOffset])
			{
				Multiply_IV32fS32f_IV32f(x, y, length);
			}
		}


		/// <summary>Multiplies double precision (64-bit) floating-point array elements by a constant and writes the result to the same array.</summary>
		/// <exception cref="System.NullReferenceException">If xArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If xArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If xOffset is negative, xOffset + length exceeds the length of xArray, or length is negative.</exception>
		public static unsafe void Multiply_IV64fS64f_IV64f(double[] xArray, int xOffset, double y, int length)
		{
			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* x = &xArray[xOffset])
			{
				Multiply_IV64fS64f_IV64f(x, y, length);
			}
		}


		/// <summary>Multiples corresponding elements in two signed 8-bit integer arrays, producing an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 8-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8sV8s_V8s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 8-bit integer arrays, producing an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 8-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8sV8s_V16s(sbyte* x, sbyte* y, short* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8sV8s_V16s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two unsigned 8-bit integer arrays, producing an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of unsigned 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of unsigned 8-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8uV8u_V16u(byte* x, byte* y, ushort* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8uV8u_V16u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 16-bit integer arrays, producing an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 16-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16sV16s_V16s(short* x, short* y, short* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16sV16s_V16s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 16-bit integer arrays, producing an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 16-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16sV16s_V32s(short* x, short* y, int* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16sV16s_V32s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two unsigned 16-bit integer arrays, producing an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of unsigned 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of unsigned 16-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16uV16u_V32u(ushort* x, ushort* y, uint* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16uV16u_V32u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 32-bit integer arrays, producing an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 32-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32sV32s_V32s(int* x, int* y, int* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32sV32s_V32s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 32-bit integer arrays, producing an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 32-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32sV32s_V64s(int* x, int* y, long* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32sV32s_V64s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two unsigned 32-bit integer arrays, producing an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of unsigned 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of unsigned 32-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32uV32u_V64u(uint* x, uint* y, ulong* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32uV32u_V64u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two signed 64-bit integer arrays, producing an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the first factor array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 64-bit integer elements.</param>
		/// <param name="product">Pointer to the product array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V64sV64s_V64s(long* x, long* y, long* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V64sV64s_V64s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two single precision (32-bit) floating-point arrays, producing an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="product">Pointer to the product array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32fV32f_V32f(float* x, float* y, float* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32fV32f_V32f(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiples corresponding elements in two double precision (64-bit) floating-point arrays, producing an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the first factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="product">Pointer to the product array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x, y, and product.</param>
		/// <exception cref="System.NullReferenceException">If x, y or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x, y or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V64fV64f_V64f(double* x, double* y, double* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V64fV64f_V64f(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant. Produces an array of signed 8-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8sS8s_V8s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8sS8s_V16s(sbyte* x, sbyte y, short* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8sS8s_V16s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies unsigned 8-bit integer array elements by a constant. Produces an array of unsigned 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of unsigned 8-bit integer elements.</param>
		/// <param name="y">The unsigned 8-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of unsigned 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V8uS8u_V16u(byte* x, byte y, ushort* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V8uS8u_V16u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant. Produces an array of signed 16-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16sS16s_V16s(short* x, short y, short* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16sS16s_V16s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16sS16s_V32s(short* x, short y, int* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16sS16s_V32s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies unsigned 16-bit integer array elements by a constant. Produces an array of unsigned 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of unsigned 16-bit integer elements.</param>
		/// <param name="y">The unsigned 16-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of unsigned 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V16uS16u_V32u(ushort* x, ushort y, uint* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V16uS16u_V32u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant. Produces an array of signed 32-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32sS32s_V32s(int* x, int y, int* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32sS32s_V32s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32sS32s_V64s(int* x, int y, long* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32sS32s_V64s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies unsigned 32-bit integer array elements by a constant. Produces an array of unsigned 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of unsigned 32-bit integer elements.</param>
		/// <param name="y">The unsigned 32-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of unsigned 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32uS32u_V64u(uint* x, uint y, ulong* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32uS32u_V64u(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 64-bit integer array elements by a constant. Produces an array of signed 64-bit integer elements.</summary>
		/// <param name="x">Pointer to the factor array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V64sS64s_V64s(long* x, long y, long* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V64sS64s_V64s(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies single precision (32-bit) floating-point array elements by a constant. Produces an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V32fS32f_V32f(float* x, float y, float* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V32fS32f_V32f(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies double precision (64-bit) floating-point array elements by a constant. Produces an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant to be multiplied by.</param>
		/// <param name="product">Pointer to the product array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and product.</param>
		/// <exception cref="System.NullReferenceException">If x or product is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or product is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_V64fS64f_V64f(double* x, double y, double* product, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_V64fS64f_V64f(x, y, product, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two signed 8-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of signed 8-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 8-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV8sV8s_IV8s(sbyte* x, sbyte* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV8sV8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two signed 16-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of signed 16-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 16-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV16sV16s_IV16s(short* x, short* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV16sV16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two signed 32-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of signed 32-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 32-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV32sV32s_IV32s(int* x, int* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV32sV32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two signed 64-bit integer arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of signed 64-bit integer elements.</param>
		/// <param name="y">Pointer to the second factor array of signed 64-bit integer elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV64sV64s_IV64s(long* x, long* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV64sV64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two single precision (32-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV32fV32f_IV32f(float* x, float* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV32fV32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies corresponding elements in two double precision (64-bit) floating-point arrays and writes the result to the first array.</summary>
		/// <param name="x">Pointer to the first factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">Pointer to the second factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV64fV64f_IV64f(double* x, double* y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV64fV64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 8-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of signed 8-bit integer elements.</param>
		/// <param name="y">The signed 8-bit integer constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV8sS8s_IV8s(sbyte* x, sbyte y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV8sS8s_IV8s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 16-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of signed 16-bit integer elements.</param>
		/// <param name="y">The signed 16-bit integer constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV16sS16s_IV16s(short* x, short y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV16sS16s_IV16s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 32-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of signed 32-bit integer elements.</param>
		/// <param name="y">The signed 32-bit integer constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV32sS32s_IV32s(int* x, int y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV32sS32s_IV32s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies signed 64-bit integer array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of signed 64-bit integer elements.</param>
		/// <param name="y">The signed 64-bit integer constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV64sS64s_IV64s(long* x, long y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV64sS64s_IV64s(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies single precision (32-bit) floating-point array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of single precision (32-bit) floating-point elements.</param>
		/// <param name="y">The single precision (32-bit) floating-point constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV32fS32f_IV32f(float* x, float y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV32fS32f_IV32f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Multiplies double precision (64-bit) floating-point array elements by a constant and writes the result to the same array.</summary>
		/// <param name="x">Pointer to the factor array of double precision (64-bit) floating-point elements.</param>
		/// <param name="y">The double precision (64-bit) floating-point constant factor.</param>
		/// <param name="length">Length of the array specified by x.</param>
		/// <exception cref="System.NullReferenceException">If x is null.</exception>
		/// <exception cref="System.DataMisalignedException">If x is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If length is negative.</exception>
		public static unsafe void Multiply_IV64fS64f_IV64f(double* x, double y, int length)
		{
			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepCore_Multiply_IV64fS64f_IV64f(x, y, new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8sV8s_V8s")]
		internal static unsafe extern Status yepCore_Multiply_V8sV8s_V8s(sbyte* x, sbyte* y, sbyte* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8sV8s_V16s")]
		internal static unsafe extern Status yepCore_Multiply_V8sV8s_V16s(sbyte* x, sbyte* y, short* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8uV8u_V16u")]
		internal static unsafe extern Status yepCore_Multiply_V8uV8u_V16u(byte* x, byte* y, ushort* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16sV16s_V16s")]
		internal static unsafe extern Status yepCore_Multiply_V16sV16s_V16s(short* x, short* y, short* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16sV16s_V32s")]
		internal static unsafe extern Status yepCore_Multiply_V16sV16s_V32s(short* x, short* y, int* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16uV16u_V32u")]
		internal static unsafe extern Status yepCore_Multiply_V16uV16u_V32u(ushort* x, ushort* y, uint* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32sV32s_V32s")]
		internal static unsafe extern Status yepCore_Multiply_V32sV32s_V32s(int* x, int* y, int* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32sV32s_V64s")]
		internal static unsafe extern Status yepCore_Multiply_V32sV32s_V64s(int* x, int* y, long* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32uV32u_V64u")]
		internal static unsafe extern Status yepCore_Multiply_V32uV32u_V64u(uint* x, uint* y, ulong* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V64sV64s_V64s")]
		internal static unsafe extern Status yepCore_Multiply_V64sV64s_V64s(long* x, long* y, long* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32fV32f_V32f")]
		internal static unsafe extern Status yepCore_Multiply_V32fV32f_V32f(float* x, float* y, float* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V64fV64f_V64f")]
		internal static unsafe extern Status yepCore_Multiply_V64fV64f_V64f(double* x, double* y, double* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8sS8s_V8s")]
		internal static unsafe extern Status yepCore_Multiply_V8sS8s_V8s(sbyte* x, sbyte y, sbyte* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8sS8s_V16s")]
		internal static unsafe extern Status yepCore_Multiply_V8sS8s_V16s(sbyte* x, sbyte y, short* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V8uS8u_V16u")]
		internal static unsafe extern Status yepCore_Multiply_V8uS8u_V16u(byte* x, byte y, ushort* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16sS16s_V16s")]
		internal static unsafe extern Status yepCore_Multiply_V16sS16s_V16s(short* x, short y, short* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16sS16s_V32s")]
		internal static unsafe extern Status yepCore_Multiply_V16sS16s_V32s(short* x, short y, int* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V16uS16u_V32u")]
		internal static unsafe extern Status yepCore_Multiply_V16uS16u_V32u(ushort* x, ushort y, uint* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32sS32s_V32s")]
		internal static unsafe extern Status yepCore_Multiply_V32sS32s_V32s(int* x, int y, int* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32sS32s_V64s")]
		internal static unsafe extern Status yepCore_Multiply_V32sS32s_V64s(int* x, int y, long* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32uS32u_V64u")]
		internal static unsafe extern Status yepCore_Multiply_V32uS32u_V64u(uint* x, uint y, ulong* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V64sS64s_V64s")]
		internal static unsafe extern Status yepCore_Multiply_V64sS64s_V64s(long* x, long y, long* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V32fS32f_V32f")]
		internal static unsafe extern Status yepCore_Multiply_V32fS32f_V32f(float* x, float y, float* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_V64fS64f_V64f")]
		internal static unsafe extern Status yepCore_Multiply_V64fS64f_V64f(double* x, double y, double* product, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV8sV8s_IV8s")]
		internal static unsafe extern Status yepCore_Multiply_IV8sV8s_IV8s(sbyte* x, sbyte* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV16sV16s_IV16s")]
		internal static unsafe extern Status yepCore_Multiply_IV16sV16s_IV16s(short* x, short* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV32sV32s_IV32s")]
		internal static unsafe extern Status yepCore_Multiply_IV32sV32s_IV32s(int* x, int* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV64sV64s_IV64s")]
		internal static unsafe extern Status yepCore_Multiply_IV64sV64s_IV64s(long* x, long* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV32fV32f_IV32f")]
		internal static unsafe extern Status yepCore_Multiply_IV32fV32f_IV32f(float* x, float* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV64fV64f_IV64f")]
		internal static unsafe extern Status yepCore_Multiply_IV64fV64f_IV64f(double* x, double* y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV8sS8s_IV8s")]
		internal static unsafe extern Status yepCore_Multiply_IV8sS8s_IV8s(sbyte* x, sbyte y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV16sS16s_IV16s")]
		internal static unsafe extern Status yepCore_Multiply_IV16sS16s_IV16s(short* x, short y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV32sS32s_IV32s")]
		internal static unsafe extern Status yepCore_Multiply_IV32sS32s_IV32s(int* x, int y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV64sS64s_IV64s")]
		internal static unsafe extern Status yepCore_Multiply_IV64sS64s_IV64s(long* x, long y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV32fS32f_IV32f")]
		internal static unsafe extern Status yepCore_Multiply_IV32fS32f_IV32f(float* x, float y, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepCore_Multiply_IV64fS64f_IV64f")]
		internal static unsafe extern Status yepCore_Multiply_IV64fS64f_IV64f(double* x, double y, System.UIntPtr length);

	}

}
