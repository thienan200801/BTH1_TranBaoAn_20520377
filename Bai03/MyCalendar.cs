using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class MyCalendar
    {
        int[] NormalYear = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        int[] LeapYear = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int d, m, y;

        public MyCalendar(int dd = 1, int mm = 1, int yyyy = 1)
        {
            d = dd;
            m = mm;
            y = yyyy;
        }
        public bool IsLeap(int n)
        {
            if (n % 400 == 0) return true;
            else if (n % 100 == 0) return false;
            else if (n % 4 == 0) return true;
            else return false;
        }
        public int NumberOfDays(int month, int year)
        {
            int res = 0;
            if (IsLeap(year)) res = LeapYear[month];
            else res = NormalYear[month];
            return res;
        }

        public bool ValidDate(int day, int month, int year)
        {
            if (IsLeap(year))
            {
                if (day >= 1 && day <= LeapYear[month]) return true;
            }
            else if (!IsLeap(year))
            {
                if (day >= 1 && day <= NormalYear[month]) return true;
            }
            return false;
        }

        public string GetDateOfWeek()
        {
            DateTime dt = new DateTime(y, m, d);
            return dt.DayOfWeek.ToString();
        }
    }
}
