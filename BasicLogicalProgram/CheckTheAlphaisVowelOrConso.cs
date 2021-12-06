using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalProgram
{
    class CheckTheAlphaisVowelOrConso
    {
        public static void printVowelOrConsonant()
        {
            char ch;
            Console.WriteLine("Enter any Alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + "Entered Alphabet is Vowel");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(ch + "Entered Alphabet is Consonant");
            }
            Console.ReadLine();
        }
    }
}
