using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 3: ");

            Console.Write("Day: ");
            int dd = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int mm = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int yyyy = int.Parse(Console.ReadLine());

            MyCalendar myCarlendar = new MyCalendar(dd, mm, yyyy);

            if (myCarlendar.ValidDate(dd, mm, yyyy))
                Console.WriteLine("Valid date");
            else Console.WriteLine("Invalid date");
        }
    }
}
