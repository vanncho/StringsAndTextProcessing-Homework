using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Words_count
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            /*
             * Problem 22. Words count
             * 
             * Write a program that reads a string from the console and lists all different words 
             * in the string along with information how many times each word is found.
             */

            string text = "Write a program that reads a string from the console and lists all different word in the string along with information how many times each word is found.";

            string[] textToArray = text.ToLower().Split(new char[] { ' ', ',', '.' });
            Dictionary<string,int> totalWordsCount = new Dictionary<string,int>();

            foreach (string word in textToArray)
            {
                if (word.Length >= 2)
                {
                    if (totalWordsCount.ContainsKey(word))
                    {
                        totalWordsCount[word]++;
                    }
                    else
                    {
                        totalWordsCount.Add(word, 1);
                    }
                }
            }

            foreach (var item in totalWordsCount)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
