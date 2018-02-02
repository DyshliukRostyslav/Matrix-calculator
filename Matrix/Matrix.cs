using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionMath
{
    public class Matrix
    {
        public int Rows { get; private set; } // rows
        public int Columns { get; private set; } // columns
        public double[,] matrix = null;  // array with matrix elements

        public Matrix(int? x = null, int? y = null)
        {
            if (x != null && y == null)
            {
                Rows = (int)x;
                Columns = (int)x;
            }
            else if (x == null && y != null)
            {
                Rows = (int)y;
                Columns = (int)y;
            }
            else if (x == null && y == null)
            {
                x = Rows = 1;
                y = Columns = 1;
            }
            else
            {
                Rows = (int)x;
                Columns = (int)y;
            }
            matrix = new double[(int)x, (int)y];

            for (int i = 0; i < (int)x; i++)
                for (int t = 0; t < (int)y; t++)
                    matrix[i, t] = 0;
        }
        public double this[int x, int y] // get element by index
        {
            get { return matrix[x, y]; }
            set { matrix[x, y] = value; }
        }

        public double[] GetRow(int row) // get row by index
        {
            if (row >= Rows) throw new IndexOutOfRangeException("The index of the row does not belong to the array.");
            double[] ret = new double[Columns];
            for (int i = 0; i < Columns; i++)
                ret[i] = (double)matrix[row, i];

            return ret;
        }
        public double[] GetColumn(int column) // get column by index
        {
            if (column >= Columns) throw new IndexOutOfRangeException("The column index (field) does not belong to the array.");
            double[] ret = new double[Rows];
            for (int i = 0; i < Rows; i++)
                ret[i] = (double)matrix[i, column];

            return ret;
        }

        public Matrix Clone()
        {
            Matrix ret = new Matrix();
            ret.Rows = Rows;
            ret.Columns = Columns;
            ret.matrix = (double[,])matrix.Clone();
            return ret;
        }

        public static double[] MulArrayConst(double[] array, double number) // multiplying an array by a number
        {
            double[] ret = (double[])array.Clone();
            for (int i = 0; i < ret.Length; i++)
                ret[i] *= number;
            return ret;
        }

        public void SetRow(double[] rowValues, int row) // set all values of the i-row
        {
            if (row >= Columns) throw new IndexOutOfRangeException("The index of the row does not belong to the array.");
            for (int i = 0; i < (Columns > rowValues.Length ? rowValues.Length : Columns); i++)
                matrix[row, i] = rowValues[i];
        }

        public void SetColumn(double[] columnValues, int column) // set all values of the i-column
        {
            if (column >= Rows) throw new IndexOutOfRangeException("The column index (field) does not belong to the array.");
            for (int i = 0; i < (Rows > columnValues.Length ? columnValues.Length : Rows); i++)
                matrix[i, column] = columnValues[i];
        }

        public static double[] SubArray(double[] A, double[] B)
        {
            double[] ret = (double[])A.Clone();
            for (int i = 0; i < (A.Length > B.Length ? A.Length : B.Length); i++)
                ret[i] -= B[i];
            return ret;
        }

        public static Matrix operator +(Matrix mA, Matrix mB) // adding matrices
        {
            if (mA.Columns != mB.Columns && mA.Rows != mB.Rows) throw new ArgumentException("The matrices should be of the same size.");
            Matrix ret = new Matrix(mA.Rows, mA.Columns);

            int size = mA.Rows;
            for (int i = 0; i < mA.Rows; i++)
                for (int j = 0; j < mA.Columns; j++)
                    ret[i, j] = mA[i, j] + mB[i, j];
            return ret;
        }

        public static Matrix operator -(Matrix mA, Matrix mB) // subtraction of matrices
        {
            if (mA.Rows != mB.Rows && mA.Columns != mB.Columns) throw new ArgumentException("The matrices should be of the same size.");
            Matrix reversB = mB*(-1);
            return mA + reversB;
        }

        public static Matrix operator *(Matrix mA, Matrix mB) // multiplication of matrices
        {
            if (mA.Columns != mB.Rows) throw new ArgumentException("The number of columns of the matrix A is not equal to the number of lines of the matrix B.");
            Matrix ret = new Matrix(mA.Rows, mB.Columns);
            for (int i = 0; i < mA.Rows; i++)
                for (int j = 0; j < mB.Columns; j++)
                    for (int k = 0; k < mB.Rows; k++)
                        ret[i, j] += mA[i, k] * mB[k, j];

            return ret;
        }

        public static Matrix operator *(Matrix mA, double number) // multiplication by number
        {
            Matrix ret = mA.Clone();
            int size = mA.Rows;
            for (int i = 0; i < mA.Rows; i++)
                for (int j = 0; j < mA.Columns; j++)
                    ret[i, j] = mA[i, j] * number;
            return ret;
        }

        public static Matrix operator ~(Matrix mA) // matrix transposition
        {
            Matrix ret = new Matrix(mA.Rows, mA.Columns);
            for (int i = 0; i < mA.Columns; i++)
            {
                for (int j = 0; j < mA.Rows; j++)
                {
                    ret[j, i] = mA[i, j];
                }
            }
            return ret;
        }
    }
}
