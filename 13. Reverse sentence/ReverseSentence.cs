using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.Reverse_sentence
{
    class ReverseSentence
    {
        static void Main(string[] args)
        {
            /*
             * Problem 13. Reverse sentence
             * 
             * Write a program that reverses the words in given sentence.
             * Example:
             * input	                                    output
             * C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!
            */

            string sentence = "C# is not C++, not PHP and not Delphi!";
            StringBuilder temp = new StringBuilder();

            int textLength = sentence.Length;
            string lastString = sentence[textLength - 1].ToString();

            List<char> tempWord = new List<char>();
            
            for (int i = sentence.Length - 2; i >= 0; i--)
            {
                if (sentence[i] != ' ' && sentence[i] != ',')
                {
                    tempWord.Add(sentence[i]);
                }
                if (sentence[i] == ' ' || i == 0)
                { 
                    tempWord.Reverse();
                    tempWord.Add(sentence[i]);
            
                    foreach (char symbol in tempWord)
                    {
                        temp.Append(symbol);
                    }
                    tempWord = new List<char>();
                }
            }
            temp.Remove(sentence.Length - 2, 1);
            
            Console.Write("{0}{1}", temp, lastString);
            Console.WriteLine();
        }
    }
}
