using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    public class PercentageOFHeadAndTail
    {
        public void printHeadAndTail()
        {
            int head = 0;
            int tail = 0;
            int CoinResult = 0;
            Random random = new Random();
            Console.WriteLine("Enter the I/P Coin Flip");
            int readInputFromUserNum = int.Parse(Console.ReadLine());
            for (int i = 0; i <= readInputFromUserNum; i++)
            {
                CoinResult = random.Next(0, 2);
                if (CoinResult == 0)
                {
                    head++;
                }
                else
                {
                    tail++;
                }
            }
            double resulthead = (head * 100) / readInputFromUserNum;
            double resulttail = (tail * 100) / readInputFromUserNum;
            Console.WriteLine("Head is Flip" + resulthead);
            Console.WriteLine("Tail is Flip" + resulttail);



        }
    }
}
