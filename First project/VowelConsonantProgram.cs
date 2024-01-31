using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
     public class VowelConsonantProgram
    {
        public static void DetermineAndPrint()
        {
            Console.Write("Enter a single character: ");
            char userInput = Convert.ToChar(Console.ReadLine());

            char lowercaseChar = char.ToLower(userInput);

            string result = DetermineVowelConsonant(lowercaseChar);

            Console.WriteLine($"The character '{userInput}' is a {result}.");
        }

        static string DetermineVowelConsonant(char character)
        {
            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return "vowel";
                default:
                    return "consonant";
            }
        }
    }
}
