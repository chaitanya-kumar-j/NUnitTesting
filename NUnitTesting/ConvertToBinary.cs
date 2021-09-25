using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class ConvertToBinary
    {
        public int ToBinary()
        {
            // get decimal number
            Console.WriteLine("Enter the decimal number between 0 to 255 only: ");
            int decimalNumber = Convert.ToInt32(Console.ReadLine());
            // initialize variable
            int binaryNumber= 0, count = 0, digit;
            Console.WriteLine($"Binary equivalent of {decimalNumber} is ");
            while (decimalNumber >= 2)
            {
                digit = decimalNumber%2;
                decimalNumber /= 2;
                binaryNumber += digit * Convert.ToInt32(Math.Pow(10,count));
                count++;
            }
            binaryNumber += decimalNumber * Convert.ToInt32(Math.Pow(10, count));
            Console.Write($" {binaryNumber}\n");
            return binaryNumber;
        }
    }
}
