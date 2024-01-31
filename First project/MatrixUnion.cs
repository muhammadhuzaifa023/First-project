using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    public  class MatrixUnion
    {
        public  static int[,] MatrixUnionVertical(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);

            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            if (cols1 != cols2)
            {
                throw new InvalidOperationException("Matrices must have the same number of columns for vertical union.");
            }

            int[,] resultMatrix = new int[rows1 + rows2, cols1];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    resultMatrix[i, j] = matrix1[i, j];
                }
            }

            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    resultMatrix[rows1 + i, j] = matrix2[i, j];
                }
            }

            return resultMatrix;
        }

    }
}
