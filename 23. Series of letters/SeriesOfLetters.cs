using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Series_of_letters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            /*
             * Problem 23. Series of letters
             * 
             * Write a program that reads a string from the console and replaces all series of 
             * consecutive identical letters with a single one.
             * 
             * Example:
             * input	                    output
             * aaaaabbbbbcdddeeeedssaa	    abcdedsa
             */

            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder formatedText = new StringBuilder();

            ////Вариант: 1
            //for (int i = 0; i < text.Length - 1; i++)
            //{
            //    if (i < text.Length - 2)
            //    {
            //        if (text[i] == text[i + 1])
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            formatedText.Append(text[i]);
            //        }
            //    }
            //    else
            //    {
            //        formatedText.Append(text[text.Length - 1]);
            //    }
            //}


            //Вариант: 2
            formatedText.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != formatedText[formatedText.Length - 1])
                {
                    formatedText.Append(text[i]);
                }
            }

            Console.WriteLine(formatedText);
        }
    }
}
