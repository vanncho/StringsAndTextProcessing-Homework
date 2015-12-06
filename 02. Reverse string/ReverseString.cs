using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_string
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            /*
             * Problem 2. Reverse string
             * Write a program that reads a string, reverses it and prints the result at the console.
             * Example:
             * input	output
             * sample	elpmas
            */

            string text = "sample";
            StringBuilder rev = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                rev.Append(text[i].ToString());
            }

            Console.WriteLine(rev);
        }
    }
}
