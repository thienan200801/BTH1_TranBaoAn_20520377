using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class MyArray
    {
        private int[] arr;
        private int n;
        public MyArray(int n)
        {
            this.n = n;
            arr = new int[n];
        }
        public void CreateArray()
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(10);
            }

            Console.Write("Array A: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        public void Input()
        {
            string tmp;
            Console.WriteLine("Input value of array, seperated by space: ");
            tmp = Console.ReadLine();

            string[] words = tmp.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                int number = 0;
                bool success = int.TryParse(words[i], out number);
                if (success)
                {
                    arr[i] = number;
                };
            };


            Console.Write("Array A: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }

        public bool OddNumber(int k)
        {
            if (k % 2 != 0) return true;
            return false;
        }
        public int SumOfOddNumber()
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (OddNumber(arr[i]))
                {
                    sum += arr[i];
                }
            }
            return sum;
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
        public int CountPrimeNumber()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrimeNumber(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }
        public bool IsSquareNumber(int n)
        {
            if ((int)Math.Sqrt(n) == Math.Sqrt(n)) return true;
            else return false;
        }
        public int MinSquareNumber()
        {
            int res = Int32.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (IsSquareNumber(arr[i]) && arr[i] < res) res = arr[i];
            }
            if (res == Int32.MaxValue) return -1;
            return res;
        }

        public int SumOfPrimeNumber()
        {
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrimeNumber(arr[i]))
                {
                    res += arr[i];
                }
            }
            return res;
        }
    }
}
