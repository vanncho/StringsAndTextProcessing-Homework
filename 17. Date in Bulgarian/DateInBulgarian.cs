using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Date_in_Bulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            /*
             * Problem 17. Date in Bulgarian
             * 
             * Write a program that reads a date and time given in the format: 
             * day.month.year hour:minute:second and prints the date and time after 
             * 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
             */

            Console.Write("Enter date and time (day.month.year hour:minute:second): ");
            string dayOne = Console.ReadLine();

            string[] arrOne = dayOne.Split('.',' ',':').ToArray();

            DateTime input = new DateTime(int.Parse(arrOne[2]), int.Parse(arrOne[1]), int.Parse(arrOne[0]), int.Parse(arrOne[3]), int.Parse(arrOne[4]), int.Parse(arrOne[5]));
            DateTime next = input.AddHours(6).AddMinutes(30);
            Console.WriteLine(next.ToString("dd.MM.yyyy:HH:MM:ss", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
