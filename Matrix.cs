using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_matrix
{
    internal class Matrix
    {
        int[,] matrix;
        public Matrix(int rows = 2, int cols = 2) {
            matrix = new int[rows, cols];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(100);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append($"{matrix[i, j],7}");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public void fillRandom(int min, int max)
        {
            var rand = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(min, max);
                }
            }
        }
       
        public int this[int r, int c]
        {
            get => matrix[r, c];
            set => matrix[r, c] = value;
        }
        public int Min()
        {
            int min = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min) min = matrix[i, j];
                }
            }
            return min;
        }
        public int Max()
        {
            int max = matrix[0,0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < max) max = matrix[i, j];
                }
            }
            return max;
        }
        public static Matrix operator +(Matrix left, Matrix right)
        {
            int first_length = left.matrix.GetLength(0);
            if (left.matrix.GetLength(0) > right.matrix.GetLength(0)) first_length = right.matrix.GetLength(0);
            int second_length = left.matrix.GetLength(1);
            if (left.matrix.GetLength(1) > right.matrix.GetLength(1)) first_length = right.matrix.GetLength(1);
            Matrix result = new Matrix(first_length, second_length);
            for (int i = 0; i < first_length; i++)
            {
                for (global::System.Int32 j = 0; j < second_length; j++)
                {
                    result[i,j] = left.matrix[i,j] + right.matrix[i,j]; 
                }
            }

            return result;
        }
        public static Matrix operator -(Matrix left, Matrix right)
        {
            int first_length = left.matrix.GetLength(0);
            if (left.matrix.GetLength(0) > right.matrix.GetLength(0)) first_length = right.matrix.GetLength(0);
            int second_length = left.matrix.GetLength(1);
            if (left.matrix.GetLength(1) > right.matrix.GetLength(1)) first_length = right.matrix.GetLength(1);
            Matrix result = new Matrix(first_length, second_length);
            for (int i = 0; i < first_length; i++)
            {
                for (global::System.Int32 j = 0; j < second_length; j++)
                {
                    result[i, j] = left.matrix[i, j] - right.matrix[i, j];
                }
            }

            return result;
        }
        public static Matrix operator *(Matrix left, Matrix right)
        {
            int first_length = left.matrix.GetLength(0);
            if (left.matrix.GetLength(0) > right.matrix.GetLength(0)) first_length = right.matrix.GetLength(0);
            int second_length = left.matrix.GetLength(1);
            if (left.matrix.GetLength(1) > right.matrix.GetLength(1)) first_length = right.matrix.GetLength(1);
            Matrix result = new Matrix(first_length, second_length);
            for (int i = 0; i < first_length; i++)
            {
                for (global::System.Int32 j = 0; j < second_length; j++)
                {
                    result[i, j] = left.matrix[i, j] * right.matrix[i, j];
                }
            }

            return result;
        }
        public static Matrix operator *(Matrix left, int right)
        {
            int first_length = left.matrix.GetLength(0);
            int second_length = left.matrix.GetLength(1);
            Matrix result = new Matrix(first_length, second_length);
            for (int i = 0; i < first_length; i++)
            {
                for (global::System.Int32 j = 0; j < second_length; j++)
                {
                    result[i, j] = left.matrix[i, j] * right;
                }
            }
            return result;
        }


        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Matrix other = obj as Matrix;
            if (other.matrix.GetLength(0) != matrix.GetLength(0) || other.matrix.GetLength(1) != matrix.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (global::System.Int32 j = 0; j < matrix.GetLength(0); j++)
                {
                    if (other.matrix[i,j] != matrix[i,j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator ==(Matrix left, Matrix right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(Matrix left, Matrix right)
        {
            return !left.Equals(right);
        }
        public void Print() {
            Console.WriteLine(this.ToString());
        }
    }
}
