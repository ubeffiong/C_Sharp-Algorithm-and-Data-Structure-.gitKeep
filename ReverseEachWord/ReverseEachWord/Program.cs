using System;
using System.Collections.Generic;
using System.Text;

namespace ReverseEachWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("      NOT EVERYONE CAN READ THIS: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" EFFIONG UBOKOBONG: @Ubeffiong - Github");
            Console.ResetColor();
            //reverseWord(Console.ReadLine());
            Console.WriteLine("");

            String str = " if you can read this, \n" +
                " you have a strange mind too \n" +
                " I couldnt beleive that I could \n" +
                " understood and developed what \n" +
                " logic I had in mind - \n" +
                " The phenomenal power of the human mind \n" +
                " Following this algorithm : \n" +
                " It dosent matter in what order the letters \n" +
                " in a word are , the only important thing is that \n" +
                " the first and last letter be in the right place \n" +
                " The rest can be a total mess \n" +
                " and you can still read it perfectly \n" +
                " This is because the human mind does not \n" +
                " read every letter by itself \n" +
                " but the word as a whole. Amazing uhh ? \n" +
                " Yeah you and I always thought \n" +
                " spelling was important! \n" +
                " If you can read this SHARE IT";
            reverseWords(str);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Can you read this? ");
            Console.Write(" If you can read this - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" SHARE IT !!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Only 55 people out of 100 can");
            Console.WriteLine("");
            Console.WriteLine(" @Ubeffiong  - C# Console");
            Console.ReadKey();
        }

        // Function to reverse the given word except the first and the last character
        static String reverseInnerLetter(string word)
        {
            int len = word.Length;          
            int i = 1; int j = word.Length - 2;
            char[] strchar = word.ToCharArray();
                      
            while (i < j)
            {                            
                char temp = strchar[i];
                strchar[i] = strchar[j];
                strchar[j] = temp;
                i++; j--;
            }
            word = new String(strchar);           
            return word;
        }
        static void reverseWords(String str)
        {
            String[] each = str.Split(' ');
            foreach (String k in each)
            {
                Console.Write(reverseInnerLetter(k) + " ");
            }
        }
    }
}

