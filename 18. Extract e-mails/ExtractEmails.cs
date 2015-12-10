using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18.Extract_e_mails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            /*
             * Problem 18. Extract e-mails
             * 
             * Write a program for extracting all email addresses from given text.
             * All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
             */

            //string text = "All sub-strings that match the format identifier@host.com should be recognized as emails.";

            string strRegex = @"[A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string text = "All sub-strings that match the format identifier@host.com should be recognized as emails.";

            foreach (Match myMatch in myRegex.Matches(text))
            {
                if (myMatch.Success)
                {
                    Console.WriteLine(myMatch);
                }
            }
        }
    }
}
