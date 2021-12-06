using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class CheckTheYearIsLeapOrNot
    {
        public static void IsLeapYear()
            {
                int Year;

                Console.WriteLine("Enter A Year:Year");
                Year = Convert.ToInt32(Console.ReadLine());
                if (Year % 4 == 0)
                {
                    Console.WriteLine("The Given Year is a Leap year");
                }
                else if (Year % 4 != 0)
                {
                    Console.WriteLine("The given Year is not a Leap Year");
                }
                Console.ReadLine();
            }
        }
}
