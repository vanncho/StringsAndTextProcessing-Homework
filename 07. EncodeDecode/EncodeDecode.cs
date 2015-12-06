using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.EncodeDecode
{
    class EncodeDecode
    {
        static void Main(string[] args)
        {
            /*
             * Problem 7. Encode/decode
             * 
             * Write a program that encodes and decodes a string using given encryption key (cipher).
             * The key consists of a sequence of characters.
             * The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
             * of the string with the first of the key, the second – with the second, etc. When the last key 
             * character is reached, the next is the first.
             */

            string text = "hello";
            string encryptedText = Caesar(text, 20);
            string decryptedText = Caesar(encryptedText, -20);

            Console.WriteLine(text);
            Console.WriteLine(encryptedText);
            Console.WriteLine(decryptedText);
        }

        static string Caesar(string value, int shift)
        {
            char[] chars = value.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                char letter = chars[i];
                letter = (char)(letter + shift);

                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }

                if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }

                chars[i] = letter;
            }
            return new string (chars);
        }
    }
}
