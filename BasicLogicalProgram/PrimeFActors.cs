using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class PrimeFActors
    {
        public void getFactors()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            while (number > 1)
            {
                while (number % i == 0)
                {
                    Console.WriteLine(i);
                    number = number / i;
                }

                i++;
            }
        }
    }
}
