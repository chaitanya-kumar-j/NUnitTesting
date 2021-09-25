using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class Binary
    {
        int binaryNumber = new ConvertToBinary().ToBinary();
        public void Swap()
        {
            int firstNibble = binaryNumber % 10000;
            int secondNibble = binaryNumber / 10000;
            int swappedBinary = (firstNibble * 10000) + secondNibble;
            Console.WriteLine($"{firstNibble}\n{secondNibble}\n{swappedBinary}");
            int swappedDecimalNumber = 0, i = 0;
            while (swappedBinary > 0)
            {
                int digit = swappedBinary % 10;
                swappedDecimalNumber += Convert.ToInt32(Math.Pow(2, i));
                swappedBinary /= 10;
                i++;
            }
            Console.WriteLine($"Decimal equivalent of swapped binary is {swappedDecimalNumber}");
        }
    }
}
