using System;

namespace BasicLogicalProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
        Label: Console.WriteLine("Print the Percentage of Coin Flip");
            Console.WriteLine("Type the option1)Print the Percentage Of Coin Flip 2)Print the Number is Even Or Odd 3)Print the Alphabet is Vowel or Consonant4)Print the Year is Leap Or Not 5)Print the Power Of two 6)Print the Swaepping Numbers 7)Print the Largest Number 8)Print the Qoutient and Remainder 9)Print The Harmonic Number 10)Print the Factors");
             int i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("1)Print the Percentage Of Coin Flip");
                    PercentageOFHeadAndTail percentageOFHeadAndTail = new PercentageOFHeadAndTail();
                    percentageOFHeadAndTail.printHeadAndTail();
                    break;
                case 2:
                    Console.WriteLine("2)Print the Number is Even Or Odd");
                    CheckWhetherNumisEvenOROdd checkWhetherNumisEvenOROdd = new CheckWhetherNumisEvenOROdd();
                    checkWhetherNumisEvenOROdd.printEvenOrOdd();
                    break;
                case 3:
                    Console.WriteLine("3)Print the Alphabet is VowelOrConsonant");
                    CheckTheAlphaisVowelOrConso checkTheAlphaisVowelOrConso = new CheckTheAlphaisVowelOrConso();
                    CheckTheAlphaisVowelOrConso.printVowelOrConsonant();
                    break;
                case 4:
                    Console.WriteLine("4)Print the Year is Leap Or Not");
                    CheckTheYearIsLeapOrNot checkTheYearIsLeapOrNot = new CheckTheYearIsLeapOrNot();
                    CheckTheYearIsLeapOrNot.IsLeapYear();
                    break;
                case 5:
                    Console.WriteLine("5)Print the Power Of two");
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    PowerOfTwo.CheckPowerOFTwo();
                    break;
                case 6:
                    Console.WriteLine("6)Print the Swapping Numbers");
                    SwappingTwoNumbers swappingTwoNumbers = new SwappingTwoNumbers();
                    SwappingTwoNumbers.CheckNumSwapping();
                    break;
                case 7:
                    Console.WriteLine("7)Print the Largest Number");
                    CheckingLargeNum checkingLargeNum = new CheckingLargeNum();
                    CheckingLargeNum.LargestNum();
                    break;
                case 8:
                    Console.WriteLine("8)Print the Qoutient and Remainder");
                    CheckingQoutientAndReminder checkingQoutientAndReminder = new CheckingQoutientAndReminder();
                    CheckingQoutientAndReminder.FindQoutientAndRemainder();
                    break;
                case 9:
                    Console.WriteLine("9)Print The Harmonic Number");
                    CheckingTheNumIsHarmonic checkingTheNumIsHarmonic = new CheckingTheNumIsHarmonic();
                    checkingTheNumIsHarmonic.isHarmonic();
                    break;
                case 10:
                    Console.WriteLine("10)Print the Factors");
                    PrimeFActors primeFActors = new PrimeFActors();
                    primeFActors.getFactors();
                    break;



                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

            Console.WriteLine("Do you want to cointinue....Yes/No");
            if (Console.ReadKey().Key.ToString() == "Yes")
            {
                goto Label;
            }
            Console.ReadKey();
        }

    }
}

                  