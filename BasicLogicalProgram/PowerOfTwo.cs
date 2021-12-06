using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class PowerOfTwo
    {
        public static void CheckPowerOFTwo()
        {
            Console.WriteLine("Enter a Num Which is Less than 31");
            int UserInput = int.Parse(Console.ReadLine());
            int Num = 1;
            for (int i = 0; i < UserInput; i++)
            {
                Num = Num * 2;
                Console.WriteLine(+Num);

            }
        }
    }
}
