using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 5: ");

            Console.Write("Day: ");
            int dd = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int mm = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int yyyy = int.Parse(Console.ReadLine());

            MyCalendar myCarlendar = new MyCalendar(dd, mm, yyyy);
            Console.WriteLine("Day of week: " + myCarlendar.GetDateOfWeek());
        }
    }
}
