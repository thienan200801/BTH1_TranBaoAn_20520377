using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    class MyMatrix
    {
        int col;
        int row;
        int[,] data;
        public MyMatrix(int row = 0, int col = 0)
        {
            this.row = row;
            this.col = col;
            data = new int[row, col];
        }

        public void InputMatrix()
        {
            var rand = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    data[i, j] = rand.Next(0, 10);
                }
            }
        }

        public void Print()
        {

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int MaxNumber()
        {
            int max = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (data[i, j] > max) max = data[i, j];
                }

            }
            return max;
        }

        public int MinNumber()
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (data[i, j] < min) min = data[i, j];
                }
            }
            return min;
        }

        public int SumRow(int row)
        {
            int result = 0;
            for (int i = 0; i < col; i++) result += data[row, i];
            return result;
        }

        public int SumCol(int col)
        {
            int result = 0;
            for (int i = 0; i < row; i++) result += data[i, col];
            return result;
        }
        public int MaxSumRow(out int maxSum)
        {
            maxSum = SumRow(0);
            int index = 0;
            for (int i = 1; i < row; i++)
            {
                int sum = SumRow(i);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            };
            return index;
        }

        public int MaxSumCol()
        {
            int maxSum = SumCol(0);
            int index = 0;
            for (int i = 1; i < col; i++)
            {
                int sum = SumCol(i);
                if (sum > maxSum)
                {
                    maxSum = sum;
                    index = i;
                }
            };
            return index;
        }
        public bool IsPrimeNumber(int number)
        {
            if (number == 0 || number == 1) return false;
            if (number == 2) return true;
            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public int SumNotPrimeNumbers()
        {
            int result = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (!IsPrimeNumber(data[i, j])) result += data[i, j];
                }
            }
            return result;
        }

        public void DeleteRow(int rowToDelete)
        {
            int[,] newMatrix = new int[row - 1, col];
            int j = 0;
            for (int i = 0; i < row; i++)
            {
                if (i == rowToDelete) continue;
                for (int k = 0; k < col; k++) newMatrix[j, k] = data[i, k];
                j++;
            }
            data = newMatrix;
            row--;
        }

        public void Delete_MaxSumCol()
        {
            int col_to_delete = MaxSumCol();
            int[,] newMatrix = new int[row, col - 1];
            int j = 0;
            for (int i = 0; i < col; i++)
            {
                if (i == col_to_delete) continue;
                for (int k = 0; k < row; k++) newMatrix[k, j] = data[k, i];
                j++;
            }
            data = newMatrix;
            col--;
        }
    }
}
