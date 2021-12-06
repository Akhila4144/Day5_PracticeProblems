using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class CheckingLargeNum
    {
        public static void LargestNum()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("num1 is larger than num2 and num3 ");
                Console.ReadLine();
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("num2 is larger than num1 and num3");
                Console.ReadLine();
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("num3 is larger than num1 and num3");
                Console.ReadLine();
            }

        }

    }
}
