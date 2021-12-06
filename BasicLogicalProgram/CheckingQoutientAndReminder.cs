using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class CheckingQoutientAndReminder
    {
        public static void FindQoutientAndRemainder()
        {
            int dividend, divisor, qoutient, remainder;
            Console.WriteLine("Enter a dividend");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor");
            divisor = Convert.ToInt32(Console.ReadLine());
            qoutient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("The Qoutient of 2 numbers:" + qoutient);
            Console.WriteLine("The Remainder of 2 numbers:" + remainder);
        }

    }
}
