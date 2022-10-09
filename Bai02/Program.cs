using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 2: ");

            Console.Write("Length = ");
            int n = int.Parse(Console.ReadLine());
            MyArray arr = new MyArray(n);
            arr.Input();
            Console.Write("Sum of prime number that less than n = ");
            Console.WriteLine(arr.SumOfPrimeNumber());
        }
    }
}
