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
            year -= (14 - month) / 12;
            year *= (1 + (1 / 4)) * (1 - 1 / 100);
            month = month + 12 * ((14 - month) / 12) - 2;
            day = (day + year + (31 * month / 12)) % 7;
            Console.WriteLine($"Day of the week is {day} i.e., {days[day]}");
        }
        public void TempConv()
        {
            // initialize variables
            decimal farenheatTemp, celciusTemp;
            // check farenheat to celcius or celcius to farenheit
            Console.WriteLine("Enter 1 to convert from farenheat to celcius, otherwise\n" +
                "Enter 2 to convert from celcius to farenheat");
            int check = Convert.ToInt32(Console.ReadLine());
            if (check == 1)
            {
                Console.WriteLine("Enter temperature in farenheat");
                farenheatTemp = Convert.ToDecimal(Console.ReadLine());
                celciusTemp = (farenheatTemp - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Enter temperature in celcius");
                celciusTemp = Convert.ToDecimal(Console.ReadLine());
                farenheatTemp = (celciusTemp * 9 / 5) + 32;
            }
            Console.WriteLine($"Temperature in celcius is: {celciusTemp}\nTemperature in farenheat is: {farenheatTemp}");
        }
        // Monthly payment calculation method
        public void MonthlyPayment()
        {
            // initialize variables
            double r, n;
            // Get the P, T, R values
            Console.WriteLine("Enter the Loan amount taken");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of years in which Loan amount has to be paid");
            double T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter yearly interest rate ");
            double R = Convert.ToDouble(Console.ReadLine());
            r = R / 1200;
            n = T * 12;
            double monthlyPayment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine($"Monthly payment to be done to payoff the loan amount of {P} " +
                $"with annual interest rate of {R}, in {T} years is {monthlyPayment}");
        }
    }
}
