using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Date_difference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            /*
             * Problem 16. Date difference
             * 
             * Write a program that reads two dates in the format: day.month.year and calculates 
             * the number of days between them.
             * 
             * Example:
             * Enter the first date: 27.02.2006
             * Enter the second date: 3.03.2006
             * Distance: 4 days
             */
            Console.Write("Enter the first date: ");
            string dayOne = Console.ReadLine();

            Console.Write("Enter the second date: ");
            string dayTwo = Console.ReadLine();

            string[] arrOne = dayOne.Split('.').ToArray();
            string[] arrTwo = dayTwo.Split('.').ToArray();

            DateTime firstDay = new DateTime(int.Parse(arrOne[2]), int.Parse(arrOne[1]), int.Parse(arrOne[0]));
            DateTime secondDay = new DateTime(int.Parse(arrTwo[2]), int.Parse(arrTwo[1]), int.Parse(arrTwo[0]));

            double diff = (secondDay - firstDay).TotalDays;

            Console.WriteLine("Distance: {0} days", diff);
        }
    }
}
