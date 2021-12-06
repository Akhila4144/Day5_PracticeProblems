using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    public class CheckWhetherNumisEvenOROdd
    {
        public void printEvenOrOdd()
        {
            int num=0;
             Console.WriteLine("Enter a num to Check If it is Even or Odd");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("The given num is Even");

            }
            else
            {
                Console.WriteLine("The given num is Odd");
                Console.ReadKey();
            }
        }
    }
}

