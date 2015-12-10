using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Word_dictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            /*
             * Problem 14. Word dictionary
             * 
             * A dictionary is stored as a sequence of text lines containing words and their explanations.
             * Write a program that enters a word and translates it by using the dictionary.
             *
             * Sample dictionary:
             * input	        output
             * .NET	            platform for applications from Microsoft
             * CLR	            managed execution environment for .NET
             * namespace	    hierarchical organization of classes
             */

            Dictionary<string, string> firstDictionary = new Dictionary<string, string>();

            firstDictionary.Add(".NET", "platform for applications from Microsoft");
            firstDictionary.Add("CLR", "managed execution environment for .NET");
            firstDictionary.Add("namespace", "hierarchical organization of classes");

            Console.Write("Enter input word: ");
            string input = Console.ReadLine();

            
            if (firstDictionary.ContainsKey(input))
            {
                Console.WriteLine("{0} is: {1}", input, firstDictionary[input]);
            }
            else
            {
                Console.WriteLine("not valid input!");
            }
        }
    }
}
