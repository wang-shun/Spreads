using System.Runtime.InteropServices;

namespace Spreads.Yeppp
{

	/// <summary>Vector mathematical functions</summary>
	public partial class Math
	{


		/// <summary>Evaluates polynomial with single precision (32-bit) floating-point coefficients on an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="xArray">Array of elements on which the polynomial will be evaluated.</param>
		/// <param name="xOffset">Offset of the first element in xArray.</param>
		/// <param name="coefArray">Array of polynomial coefficients.</param>
		/// <param name="coefOffset">Offset of the first element in yArray.</param>
		/// <param name="yArray">Array where the result of polynomial evaluation will be stored.</param>
		/// <param name="yOffset">Offset of the first element in yArray.</param>
		/// <param name="coefCount">The length of the slice of coef to be used in computation.</param>
		/// <param name="length">The length of the slice of xArray and yArray to use in computation.</param>
		/// <exception cref="System.NullReferenceException">If coefArray, xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If coefArray, xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If coefCount or length is negative or coefCount is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If coefOffset is negative, coefOffset + coefCount exceeds the length of coefArray, xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, coefCount is negative, or length is negative.</exception>
		public static unsafe void EvaluatePolynomial_V32fV32f_V32f(float[] coefArray, int coefOffset, float[] xArray, int xOffset, float[] yArray, int yOffset, int coefCount, int length)
		{
			if (coefOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (coefOffset + coefCount > coefArray.Length)
				throw new System.IndexOutOfRangeException();

			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (coefCount < 0)
				throw new System.ArgumentException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (float* coef = &coefArray[coefOffset])
			{
				fixed (float* x = &xArray[xOffset])
				{
					fixed (float* y = &yArray[yOffset])
					{
						EvaluatePolynomial_V32fV32f_V32f(coef, x, y, coefCount, length);
					}
				}
			}
		}


		/// <summary>Evaluates polynomial with double precision (64-bit) floating-point coefficients on an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="xArray">Array of elements on which the polynomial will be evaluated.</param>
		/// <param name="xOffset">Offset of the first element in xArray.</param>
		/// <param name="coefArray">Array of polynomial coefficients.</param>
		/// <param name="coefOffset">Offset of the first element in yArray.</param>
		/// <param name="yArray">Array where the result of polynomial evaluation will be stored.</param>
		/// <param name="yOffset">Offset of the first element in yArray.</param>
		/// <param name="coefCount">The length of the slice of coef to be used in computation.</param>
		/// <param name="length">The length of the slice of xArray and yArray to use in computation.</param>
		/// <exception cref="System.NullReferenceException">If coefArray, xArray or yArray is null.</exception>
		/// <exception cref="System.DataMisalignedException">If coefArray, xArray or yArray is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If coefCount or length is negative or coefCount is zero.</exception>
		/// <exception cref="System.IndexOutOfRangeException">If coefOffset is negative, coefOffset + coefCount exceeds the length of coefArray, xOffset is negative, xOffset + length exceeds the length of xArray, yOffset is negative, yOffset + length exceeds the length of yArray, coefCount is negative, or length is negative.</exception>
		public static unsafe void EvaluatePolynomial_V64fV64f_V64f(double[] coefArray, int coefOffset, double[] xArray, int xOffset, double[] yArray, int yOffset, int coefCount, int length)
		{
			if (coefOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (coefOffset + coefCount > coefArray.Length)
				throw new System.IndexOutOfRangeException();

			if (xOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (xOffset + length > xArray.Length)
				throw new System.IndexOutOfRangeException();

			if (yOffset < 0)
				throw new System.IndexOutOfRangeException();

			if (yOffset + length > yArray.Length)
				throw new System.IndexOutOfRangeException();

			if (coefCount < 0)
				throw new System.ArgumentException();

			if (length < 0)
				throw new System.ArgumentException();

			fixed (double* coef = &coefArray[coefOffset])
			{
				fixed (double* x = &xArray[xOffset])
				{
					fixed (double* y = &yArray[yOffset])
					{
						EvaluatePolynomial_V64fV64f_V64f(coef, x, y, coefCount, length);
					}
				}
			}
		}


		/// <summary>Evaluates polynomial with single precision (32-bit) floating-point coefficients on an array of single precision (32-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the array of elements on which the polynomial will be evaluated.</param>
		/// <param name="coef">Pointer to the array of polynomial coefficients.</param>
		/// <param name="y">Pointer the array where the result of polynomial evaluation will be stored.</param>
		/// <param name="coefCount">Number of polynomial coefficients. Should equal the polynomial degree plus one.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If coef, x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If coef, x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If coefCount or length is negative or coefCount is zero.</exception>
		public static unsafe void EvaluatePolynomial_V32fV32f_V32f(float* coef, float* x, float* y, int coefCount, int length)
		{
			if (coefCount < 0)
				throw new System.ArgumentException();

			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepMath_EvaluatePolynomial_V32fV32f_V32f(coef, x, y, new System.UIntPtr(unchecked((uint) coefCount)), new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		/// <summary>Evaluates polynomial with double precision (64-bit) floating-point coefficients on an array of double precision (64-bit) floating-point elements.</summary>
		/// <param name="x">Pointer to the array of elements on which the polynomial will be evaluated.</param>
		/// <param name="coef">Pointer to the array of polynomial coefficients.</param>
		/// <param name="y">Pointer the array where the result of polynomial evaluation will be stored.</param>
		/// <param name="coefCount">Number of polynomial coefficients. Should equal the polynomial degree plus one.</param>
		/// <param name="length">Length of the arrays specified by x and y.</param>
		/// <exception cref="System.NullReferenceException">If coef, x or y is null.</exception>
		/// <exception cref="System.DataMisalignedException">If coef, x or y is not naturally aligned.</exception>
		/// <exception cref="System.ArgumentException">If coefCount or length is negative or coefCount is zero.</exception>
		public static unsafe void EvaluatePolynomial_V64fV64f_V64f(double* coef, double* x, double* y, int coefCount, int length)
		{
			if (coefCount < 0)
				throw new System.ArgumentException();

			if (length < 0)
				throw new System.ArgumentException();

			Status status = yepMath_EvaluatePolynomial_V64fV64f_V64f(coef, x, y, new System.UIntPtr(unchecked((uint) coefCount)), new System.UIntPtr(unchecked((uint) length)));
			if (status != Status.Ok)
				throw Library.GetException(status);
		}


		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepMath_EvaluatePolynomial_V32fV32f_V32f")]
		internal static unsafe extern Status yepMath_EvaluatePolynomial_V32fV32f_V32f(float* coef, float* x, float* y, System.UIntPtr coefCount, System.UIntPtr length);

		[DllImport("yeppp", ExactSpelling=true, CallingConvention=CallingConvention.Cdecl, EntryPoint="yepMath_EvaluatePolynomial_V64fV64f_V64f")]
		internal static unsafe extern Status yepMath_EvaluatePolynomial_V64fV64f_V64f(double* coef, double* x, double* y, System.UIntPtr coefCount, System.UIntPtr length);

	}

}
