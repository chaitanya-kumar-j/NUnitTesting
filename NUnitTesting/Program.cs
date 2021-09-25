using System;

namespace NUnitTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // run or exit
            bool isRun = true;
            while (isRun)
            {
                // Select which program to run
                Console.WriteLine("\n Select a program number from 1 to 7 only to run selected program or select 8 to exit application:\n" +
                    "1. Vending Machine, 2. Day of week, 3. Temperature Conversion, 4. Monthly Payment, \n" +
                    "5. Sqare root, 6. Convert to Binary, 7. Nibbles swapped Binary to decimal, 8. Exit application");
                int selectProgram = Convert.ToInt32(Console.ReadLine());
                switch (selectProgram)
                {
                    case 1:
                        new VendingMachine().GetChangeByIter();
                        new VendingMachine().GetChangeByRecur();
                        break;
                    case 2:
                        new Util().GetDayOfWeek();
                        break;
                    case 3:
                        new Util().TempConv();
                        break;
                    case 4:
                        new Util().MonthlyPayment();
                        break;
                    case 5:
                        new SqrtByNewtonMethod().CalcSqrt();
                        break;
                    case 6:
                        new ConvertToBinary().ToBinary();
                        break;
                    case 7:
                        new Binary().Swap();
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
        }
    }
}
