using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class StringLength
    {
        static void Main(string[] args)
        {
            /*
             * Problem 6. String length
             * 
             * Write a program that reads from the console a string of maximum 20 characters. 
             * If the length of the string is less than 20, the rest of the characters should be filled with *.
             * Print the result string into the console.
             */

            
            //string text = "abcdefghijklmnopqrst";
            //string text = "abcdefghijklmnopqrst1";
            string text = "abcdefg";
            StringBuilder fullCharactersLength = new StringBuilder();

            if (text.Length == 20)
            {
                Console.WriteLine(text);
            }

            if (text.Length > 20)
            {
                Console.WriteLine("Error! The text length is more than 20 characters!");
            }

            if (text.Length < 20)
            {
                fullCharactersLength.Append(text);

                while (fullCharactersLength.Length < 20)
                {
                    fullCharactersLength.Append("*");
                }
            }
            Console.WriteLine(fullCharactersLength);
        }
    }
}
