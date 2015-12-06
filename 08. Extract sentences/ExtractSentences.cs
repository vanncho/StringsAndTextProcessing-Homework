using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Extract_sentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            /*
             * Problem 8. Extract sentences
             * 
             * Write a program that extracts from a given text all sentences containing given word.
             * 
             * Example:
             * The word is: in
             * 
             * The text is: We are living in a yellow submarine. We don't have anything else. 
             * Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
             * 
             * The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
             * Consider that the sentences are separated by . and the words – by non-letter symbols.
             */

            
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string searchingWord = "in";

            string foundSentences = FindWordInSentence(text,searchingWord);

            Console.WriteLine(foundSentences);
        }

        static string FindWordInSentence(string text, string searchingWord)
        {
            StringBuilder sentences = new StringBuilder();
            int start = 0;
            int end = 0;
            int index = 0;
            bool isFound = false;
            text = text + " ";

            for (int i = 1; i <= text.Length - 1; i++)
            {
                if (text[i - 1].ToString() == " " && text[i + 2].ToString() == " ")
                {
                    string search = text[i].ToString() + text[i + 1].ToString();

                    if (search == searchingWord)
                    {
                        start = text.IndexOf(searchingWord);
                        isFound = true;
                    }

                }

                if (text[i] == '.')
                {
                    end = text.IndexOf(".");
                    end = end + 1;

                    if (isFound == true)
                    {
                        sentences.Append(text, index, end);
                        sentences.Append(" ");
                        text = text.Remove(index, end);
                    }
                    else
                    {
                        text = text.Remove(index, end);
                    }

                    start = 0;
                    end = 0;
                    index = 1;
                    isFound = false;
                    i = 1;
                }
            }
            string sentencesAll = sentences.ToString();
            return sentencesAll;
        }
    }
}
