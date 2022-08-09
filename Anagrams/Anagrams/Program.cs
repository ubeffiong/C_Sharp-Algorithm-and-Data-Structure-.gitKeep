using System;

namespace Anagrams
{
    /*
     Two words are said to be Anagrams of each other 
    if they share the same set of letters to form the 
    respective words.for an example: 
    Silent–>Listen, 
    post–>opts.


    C# program to Determine if Two Words Are Anagrams of Each Other
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            //Receive words from user
            Console.Write("Enter first word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            //Step 1 - convert string to lower case and to character
            char[] char1 = word1.ToLower().ToCharArray();
            char[] char2 = word2.ToLower().ToCharArray();

            //Step 2 - sort words in aphabetical order
            Array.Sort(char1);
            Array.Sort(char2);

            //Step 3 - convert back character to strings
            string NewWord1 = new string(char1);
            string NewWord2 = new string(char2);

            //Step 4  
            //ToLower allows to compare the words in same case, in this case, lower case.  
            //ToUpper will also do exact same thing in this context 
            if(NewWord1 == NewWord2)
            {
                Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", word1, word2);
            }
            else
            {
                Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", word1, word2);
            }
            Console.ReadLine();
        }
    }

    /*
     The logic is:
    1. Step 1 - Convert both strings to character arrays.
    2. Step 2 - Sort the character arrays in ascending/descending order, but use the same ordering on both of the character sets.
    3. Step 3 - Create two strings out of the two sorted character set arrays.
    4. Step 4 - Compare the strings.
    5.          If they are not equal, they are not Anagrams.
    */
}
