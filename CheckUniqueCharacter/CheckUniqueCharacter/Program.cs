using System;
using System.Collections.Generic;

namespace CheckUniqueCharacter
{
    internal class Program
    {
        //Implement an algorithm to determine if a string has all unique characters
        //What if you cannot use additional data structures
        static void Main(string[] args)
        {
            //Print with method 1
            if (IsUnique("Hel!"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            //Print with method 2
            if (IsUnique2("Hello!"))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
        //Method 1 - Using a dictionary (additional data structure) to store and check for a duplicate
        public static bool IsUnique(string letter)
        {
            Dictionary<char, int> word = new Dictionary<char, int>();
            foreach (char c in letter)
            {
                if (word.ContainsKey(c))                  
                    return false; 
                word.Add(c, 1);               
            }
            return true;
        }
        //Method 2 - Comparing each characters to every other without an additional data structure
        public static bool IsUnique2(string letter)
        {
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            for (int i = 0; i < letter.Length; i++)
            {
                temp1 = letter.Substring(i, 1);
                for (int k = 0; k < letter.Length; k++)
                {
                    temp2 = letter.Substring(k, 1);
                    if ((temp1 == temp2) && (i != k))
                        return false;
                }
            }
            return true;

        }
    }
}
