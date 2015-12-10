using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            /*
             * Problem 12. Parse URL
             * 
             * Write a program that parses an URL address given in the format: 
             * [protocol]://[server]/[resource] and extracts from it the 
             * [protocol], [server] and [resource] elements.
             * 
             * Example:
             * URL	Information
             * http://telerikacademy.com/Courses/Courses/Details/212	
             * [protocol] = http 
             * [server] = telerikacademy.com 
             * [resource] = /Courses/Courses/Details/212
             */
            
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";

            var pattern = "(.*)://(.*?)(/.*)";
            var parts = Regex.Match(url, pattern).Groups;
            
            Console.WriteLine("[protocol] = {0}", parts[1]);
            Console.WriteLine("[server] = {0}", parts[2]);
            Console.WriteLine("[resource] = {0}", parts[3]);
        }
    }
}
