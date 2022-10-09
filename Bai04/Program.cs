using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 4: ");

            Console.Write("Month: ");
            int mm = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int yyyy = int.Parse(Console.ReadLine());

            MyCalendar myCarlendar = new MyCalendar(mm, yyyy);
            Console.WriteLine("Days of month: " + myCarlendar.NumberOfDays(mm, yyyy));
        }
    }
}
