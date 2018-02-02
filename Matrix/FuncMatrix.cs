using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionMath
{
    public class FuncMatrix
    {
        public static double Determinant(Matrix matrix) // Determination of the determinant by the Gauss method
        {
            if (matrix.Rows != matrix.Columns) throw new ArgumentException("Calculating a determinant is possible only for square matrices.");
            double det = 1;
            int order = matrix.Rows;

            for (int i = 0; i < order - 1; i++)
            {
                double[] masterRow = matrix.GetRow(i);
                det *= masterRow[i];
                if (det == 0) return 0;
                for (int t = i + 1; t < order; t++)
                {
                    double[] slaveRow = matrix.GetRow(t);
                    double[] tmp = Matrix.MulArrayConst(masterRow, slaveRow[i] / masterRow[i]);
                    double[] source = matrix.GetRow(t);
                    matrix.SetRow(Matrix.SubArray(source, tmp), t);
                }
            }
            det *= matrix[order - 1, order - 1];

            return det;
        }
        
        public static double[] MulArrayConst(double[] array, double number) // multiplying an array by a number
        {
            double[] ret = (double[])array.Clone();
            for (int i = 0; i < ret.Length; i++)
                ret[i] *= number;
            return ret;
        }
        public static double[] SubArray(double[] A, double[] B)
        {
            double[] ret = (double[])A.Clone();
            for (int i = 0; i < (A.Length > B.Length ? A.Length : B.Length); i++)
                ret[i] -= B[i];
            return ret;
        }
        public static int Rank(Matrix mA) // matrix rank
        {
            Matrix matrix = mA.Clone();
            int order = mA.Rows;
            // We give a triangular appearance
            for (int i = 0; i < order - 1; i++)
            {
                double[] masterRow = matrix.GetRow(i);
                double[] slaveRow = null;
                for (int t = i + 1; t < order; t++)
                {
                    slaveRow = matrix.GetRow(t);
                    double[] tmp = MulArrayConst(masterRow, slaveRow[i] / masterRow[i]);
                    double[] source = matrix.GetRow(t);
                    matrix.SetRow(SubArray(source, tmp), t);
                }
            }
            // Subtract the number of lines of zeros from the total number of rows
            for (int i = 0; i < matrix.Rows; i++)
            {
                double[] row = matrix.GetRow(i);
                int countZero = 1;
                for (int t = 0; t < row.Length; t++)
                {
                    if (row[t] != 0) break;
                    countZero++;
                }
                if (countZero == row.Length) order--;
            }

            return order;
        }
        public static Matrix Triangle(Matrix mA) // triangular shape
        {
            Matrix matrix = mA.Clone();
            int order = mA.Rows;
            // We give a triangular appearance
            for (int i = 0; i < order - 1; i++)
            {
                double[] masterRow = matrix.GetRow(i);
                double[] slaveRow = null;
                for (int t = i + 1; t < order; t++)
                {
                    slaveRow = matrix.GetRow(t);
                    double[] tmp = MulArrayConst(masterRow, slaveRow[i] / masterRow[i]);
                    double[] source = matrix.GetRow(t);
                    matrix.SetRow(SubArray(source, tmp), t);
                }
            }
            return matrix;
        }
    }
}
