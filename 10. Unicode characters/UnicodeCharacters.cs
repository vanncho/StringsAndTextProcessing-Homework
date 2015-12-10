using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Unicode_characters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            /*
             * Problem 10. Unicode characters
             * 
             * Write a program that converts a string to a sequence of C# Unicode character literals.
             * Use format strings.
             * Example:
             * input	output
             * Hi!	    \u0048\u0069\u0021
             */

            string text = "Hi!";
            int[] stringToCharArr = new int[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                stringToCharArr[i] = Convert.ToInt32(text[i]);
            }

            foreach (int item in stringToCharArr)
            {
                Console.Write("\\u00{0:X}", item);
            }
            Console.WriteLine();
        }
    }
}
