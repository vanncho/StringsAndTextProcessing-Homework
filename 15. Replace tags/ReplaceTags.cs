using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Replace_tags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            /*
             * Problem 15. Replace tags
             * 
             * Write a program that replaces in a HTML document given as string all the tags 
             * <a href="…">…</a> with corresponding tags [URL=…]…/URL].
             * 
             * Example:
             * input
             * <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. 
             * Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
             * output
             * <p>Please visit [URL=http://academy.telerik.com]our site[/URL] to choose a training course. 
             * Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
             */

            string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            var url = new StringBuilder(text);

            for (int i = 0; i < url.Length; i++)
            {
                url.Replace(">", "]");
                url.Replace("<a href=", "[URL=");
                url.Replace("</a>", "[/URL]");
                url.Replace("</a]", "</a>");
                url.Replace("<p]", "<p>");
                url.Replace("</a>", "[/URL]");
                url.Replace("p]", "p>");
            }
            Console.WriteLine(url);
        }
    }
}
