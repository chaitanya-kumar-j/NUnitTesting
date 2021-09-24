using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTesting
{
    class VendingMachine
    {
        public int Change()
        {
            // get the required change
            Console.WriteLine("Enter the amount of change you need to get, in Rs.: ");
            int changeToGet = Convert.ToInt32(Console.ReadLine());
            while (changeToGet <= 0)
            {
                Console.WriteLine("Change should be greater than 0!... ");
                Console.WriteLine("Enter the correct correct amount of change you need to get, in Rs.: ");
                changeToGet = Convert.ToInt32(Console.ReadLine());
            }
            return changeToGet;
        }
        // initialize constant
        int[] NOTES_LIST = { 1000, 500, 100, 50, 10, 5, 2, 1 };

        // initialize variables
        int notesCount = 0;
        // int changeToGet = new VendingMachine().Change();

        public void GetChangeByIter()
        {
            int changeToGet = new VendingMachine().Change();
            for (int i = 0; i < NOTES_LIST.Length; i++)
            {
                int note = NOTES_LIST[i];
                while (changeToGet / note != 0)
                {
                    notesCount += 1;
                    changeToGet -= note;
                }
                Console.WriteLine($"Number of {note} Rs. notes are: {notesCount}");
                notesCount = 0;
            }
        }
        // method to run by recursion
        public int NumberOfNotes(int changeToGet, int note)
        {
            while (changeToGet / note != 0)
            {
                notesCount += 1;
                changeToGet -= note;
            }
            Console.WriteLine($"Number of {note} Rs. notes are: {notesCount}");
            notesCount = 0;
            return changeToGet;
        }
        public void GetChangeByRecur()
        {
            int changeToGet = new VendingMachine().Change();
            foreach (int note in NOTES_LIST)
            {
                changeToGet = new VendingMachine().NumberOfNotes(changeToGet, note);
            }
        }
    }
}
