using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _21.Letters_count
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            /*
             * Problem 21. Letters count
             * 
             * Write a program that reads a string from the console and prints all different 
             * letters in the string along with information how many times each letter is found.
             */

            string text = "Write a program that.";
            //
            //foreach (char item in text.ToLower())
            //{
            //    if (char.IsLetter(item))
            //    {
            //        if (sentence.ContainsKey(item))
            //        {
            //            sentence[item]++;
            //        }
            //        else
            //        {
            //            sentence.Add(item, 1);
            //        }
            //    }
            //}
            //
            //foreach (var letter in sentence)
            //{
            //    Console.WriteLine("{0} - {1}", letter.Key, letter.Value);
            //}





            //ВТОРО РЕШЕНИЕ С БУЛЕВ МАСИВ

            bool[] visited = new bool[text.Length];
            
            
            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                if (visited[i] == false && char.IsLetter(text[i]))
                {
                    int index = text.IndexOf(text[i]);
                    while (index != -1)
                    {
                        visited[index] = true;
                        index = text.IndexOf(text[i], index + 1);
                        count++;
                    }
                    Console.WriteLine("{0} - {1} times", text[i], count);
                }
            }
        }
    }
}
