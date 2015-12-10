using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25.Extract_text_from_HTML
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            /*
             * Problem 25. Extract text from HTML
             * 
             * Write a program that extracts from given HTML file its title (if available), 
             * and its body text without the HTML tags.
             * 
             * Example input:
             * 
             * <html>
             * <head><title>News</title></head>
             * <body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world practical
             * training for young people who want to turn into skilful .NET software engineers.</p></body></html>
             * 
             * Output:
             * 
             * Title: News
             * Text: Telerik Academy aims to provide free real-world practical training for young 
             * people who want to turn into skilful .NET software engineers.
             */

            string text = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html>";
            StringBuilder extractedText = new StringBuilder();
            StringBuilder extractedTitle = new StringBuilder();
            bool enter = true;

            string pattern = ("<title>(.*?)</title>");
            Console.WriteLine("Title: {0}", Regex.Match(text, pattern).Groups[1]);
            string title = Regex.Match(text, pattern).Groups[1].ToString();

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    enter = true;
                }

                if (text[i] == '>')
                {
                    enter = false;
                    continue;
                }

                Regex appendSettings = new Regex("char.IsLetter(text[i])|,|.");

                if (appendSettings.IsMatch(text[i].ToString()) && enter == false)
                {
                    extractedText.Append(text[i]);
                }
            }

            int index = text.IndexOf(title, title.Length);
            extractedText.Remove(0, title.Length);

            Console.WriteLine(extractedText);
        }
    }
}
