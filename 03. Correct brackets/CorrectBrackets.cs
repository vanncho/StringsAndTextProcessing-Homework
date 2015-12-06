using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Correct_brackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            /*
             *Problem 3. Correct brackets
             *Write a program to check if in a given expression the brackets are put correctly.
             *
             *Example of correct expression: ((a+b)/5-d).
             *Example of incorrect expression: )(a+b)). 
             */

            string expression = ")(a+b()";

            string[] symbols = new string[expression.Length];
            
            for (int i = 0; i < symbols.Length; i++)
            {
                symbols[i] = expression[i].ToString();
            }

            for (int i = 0; i < symbols.Length - 1; i++)
            {
                if (i == 0 && symbols[i] == ")")
                {
                    symbols[i] = "(";
                }

                if (symbols[i] == "(" && symbols[i+1] == ")")
                {
                    if (symbols[i+1] != ")")
                    {
                        symbols[i + 1] = "(";
                        continue;
                    }

                    symbols[i] = ")"; 
                }

                if (symbols[i] == "(")
                {
                    switch (symbols[i+1])
                    {
                        case "+": symbols[i] = ")"; break;
                        case "-": symbols[i] = ")"; break;
                        case "*": symbols[i] = ")"; break;
                        case "/": symbols[i] = ")"; break;
                    }
                }
                if ((i + 1) == symbols.Length - 1)
                {
                    if (symbols[i + 1] == "(")
                    {
                        symbols[i + 1] = ")";
                    }
                }
            }

            for (int i = 0; i < symbols.Length; i++)
            {
                Console.Write(symbols[i]);
            }

            Console.WriteLine();
        }
    }
}
