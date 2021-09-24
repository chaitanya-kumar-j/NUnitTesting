using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class SqrtByNewtonMethod
    {
        public void CalcSqrt()
        {
            // initialize constants
            const double epsilon = 1e-15;
            // get the number 
            Console.WriteLine("Enter the number to which square root has to be calculated:");
            int c = Convert.ToInt32(Console.ReadLine());
            int t = c;
            while ((t-(c/t)) > (epsilon * t))
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine($"Square root value of {c} by Newton's method is {t}");
        }
    }
}
