using System;
using System.Collections.Generic;
using System.Text;
using BasicPrograms;

namespace NUnitTesting
{
    class Util
    {
        public void GetDayOfWeek()
        {
            string[] days = { "Sunday", " Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            // get day, month and year 
            Console.WriteLine("Enter the year");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the month of the year");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the day of the month");
            int day = Convert.ToInt32(Console.ReadLine());
            year = year - (14 - month) / 12;
            year = (1 + 1 / 4) * (1 - 1 / 100) * year;
            month = month + 12 * ((14 - month) / 12) - 2;
            day = (day + year + 31 * month / 12) % 7;
            Console.WriteLine($"Day of the week is {day} i.e., {days[day]}");
        }
    }
}
