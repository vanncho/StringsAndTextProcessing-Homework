using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Forbidden_words
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            /*
             * Problem 9. Forbidden words
             * 
             * We are given a string containing a list of forbidden words and a text containing some of these words.
             * Write a program that replaces the forbidden words with asterisks.
             * 
             * Example text: Microsoft announced its next generation PHP compiler today. It is based on 
             * .NET Framework 4.0 and is implemented as a dynamic language in CLR.
             * 
             * Forbidden words: PHP, CLR, Microsoft
             * The expected result: ********* announced its next generation *** compiler today. It is based on 
             * .NET Framework 4.0 and is implemented as a dynamic language in ***.
             */

            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            StringBuilder textInAsterisks = new StringBuilder();
            textInAsterisks.Append(text);

            string forbidenWords = "PHP, CLR, Microsoft";
            string[] arr = forbidenWords.Split(new char [] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            int countWord = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                countWord = arr[i].Length;

                for (int j = 0; j < textInAsterisks.Length - countWord; j++)
                {
                    index = text.IndexOf(arr[i]);

                    if (index < 0)
                    {
                        break;
                    }
                    else
                    {
                        textInAsterisks.Replace(arr[i], new string('*', arr[i].Length), index, countWord);
                    }
                }     
            }

            Console.WriteLine(textInAsterisks);
        }
    }
}
