using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class SwappingTwoNumbers
    {
        public static void CheckNumSwapping()
        {
            int num1, num2, tempororay;

            Console.WriteLine("Enter Any Number:num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Any Number:num2");
            num2 = int.Parse(Console.ReadLine());
            tempororay = num1;
            num1 = num2;
            num2 = tempororay;
            Console.WriteLine("After Swapping the Number1 Will be:" + num1);
            Console.WriteLine("And The Number2 will be:" + num2);
            Console.ReadLine();
        }


    }
}
