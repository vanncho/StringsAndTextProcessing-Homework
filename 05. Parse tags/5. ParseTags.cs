using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parse_tags
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Problem 5. Parse tags
             * 
             * You are given a text. Write a program that changes the text in all regions surrounded 
             * by the tags <upcase> and </upcase> to upper-case.
             * The tags cannot be nested.
             * 
             * Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
             * The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
             */

            StringBuilder parsedText = new StringBuilder();
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            
            string startWord = "<upcase>";
            string endWord = "</upcase>";
            string searchingText = String.Empty;
            int index = 0;
            int end = 0;
            int start = 0;

            while (text.IndexOf(startWord, index) > 0)
            {
                if (parsedText.Length == 0)
                {
                    parsedText.Append(text);
                }

                start = text.IndexOf(startWord, index) + startWord.Length;
                end = text.IndexOf(endWord, index);
                int textLength = end - start;

                searchingText = text.Substring(start, textLength);
                searchingText = searchingText.ToUpper();
                index = end + endWord.Length;

                parsedText.Remove(start - startWord.Length, startWord.Length + searchingText.Length + endWord.Length);
                parsedText.Insert(start - startWord.Length, searchingText);

                start = 0;
                end = 0;
                index = 0;
                text = parsedText.ToString();
            }

            Console.WriteLine(parsedText);
        }
    }
}
