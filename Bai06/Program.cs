using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 6: ");

            Console.Write("Row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Col: ");
            int col = Convert.ToInt32(Console.ReadLine());


            MyMatrix matrix = new MyMatrix(row, col);
            matrix.InputMatrix();
            matrix.Print();
            Console.WriteLine();

            Console.WriteLine("Max number: " + matrix.MaxNumber());
            Console.WriteLine("Min number: " + matrix.MinNumber());
            Console.WriteLine();

            int sum = 0;
            Console.WriteLine($"Row {matrix.MaxSumRow(out sum)} is the row having max sum (sum = {sum})");
            Console.WriteLine();

            Console.Write("Row to delete: ");
            int row_to_delete = Convert.ToInt32(Console.ReadLine());


            matrix.DeleteRow(row_to_delete);
            matrix.Print();
            Console.WriteLine();

            Console.Write("Delete column having max sum: ");


            matrix.Delete_MaxSumCol();
            Console.WriteLine();
            matrix.Print();
        }
    }
}
