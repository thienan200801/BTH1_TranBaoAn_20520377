using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai01
{
    class Program
    {
        public static void Question_1(string[] args)
        {
            Console.WriteLine("Question 1: ");

            Console.Write("Array length: ");
            int n = Convert.ToInt32(Console.ReadLine());

            MyArray A = new MyArray(n);
            A.CreateArray();

            Console.Write("Sum of odd number in array A: ");
            Console.WriteLine(A.SumOfOddNumber());

            Console.Write("Count prime number in array A: ");
            Console.WriteLine(A.CountPrimeNumber());

            Console.Write("Min square number in array A: ");
            Console.WriteLine(A.MinSquareNumber());
        }
    }
}
