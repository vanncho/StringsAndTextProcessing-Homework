using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_string_in_text
{
    class SubStringInText
    {
        static void Main(string[] args)
        {
            /*
             * Sub-string in text
             * Write a program that finds how many times a sub-string is contained in a given text 
             * (perform case insensitive search).
             * Example:
             * 
             * The target sub-string is in:
             * 
             * "The text is as follows: We are living in an yellow submarine. We don't have 
             * anything else. inside the submarine is very tight. So we are drinking all the day. 
             * We will move out of it in 5 days."
             * 
             * The result is: 9
             */

            string text = "The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            int count = 0;
            int found = 0;
            int index = 0;

            while (true)
            {
                found = text.IndexOf("in", index);
                if (found > 0)
                {
                    count++;
                }
                else
                {
                    break;
                }
                index = found + 1;
            }

            Console.WriteLine(count);
        }
    }
}
