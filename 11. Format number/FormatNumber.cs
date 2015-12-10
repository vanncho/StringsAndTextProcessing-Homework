using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Format_number
{
    public class FormatNumber
    {
        public static void Main()
        {
            /*
             * Problem 11. Format number
             * 
             * Write a program that reads a number and prints it as a decimal number, hexadecimal number,
             * percentage and in scientific notation.
             * Format the output aligned right in 15 symbols.
             */

            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15:D}: in decimal", number);

            Console.WriteLine("{0,15:X}: in hexadecimal", number);

            Console.WriteLine("{0,15:P}: in percentage", number);

            Console.WriteLine("{0,15:E}: in scientific notation", number);
        }
    }
}
