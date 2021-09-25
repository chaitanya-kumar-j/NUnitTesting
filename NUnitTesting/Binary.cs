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
            Console.WriteLine($"{firstNibble}\n{secondNibble}");
        }
    }
}
