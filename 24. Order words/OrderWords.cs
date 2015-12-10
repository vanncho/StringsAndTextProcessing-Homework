using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.Order_words
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            /*
             * Problem 24. Order words
             * 
             * Write a program that reads a list of words, separated by spaces and prints 
             * the list in an alphabetical order.
             */

            string text = "Write program that reads list of words separated by spaces and prints the list in an alphabetical order";

            string[] words = text.ToLower().Split(' ');

            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
