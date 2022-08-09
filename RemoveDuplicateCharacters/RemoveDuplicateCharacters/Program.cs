using System;

namespace RemoveDuplicateCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value1 = RemoveDuplicateChars("Ubokobong");
            string value2 = RemoveDuplicateChars("Character");
            string value3 = RemoveDuplicateChars("everyday");
            string value4 = RemoveDuplicateChars("structure");

            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);
            Console.WriteLine(value4);
        }
        static string RemoveDuplicateChars(string key)
        {
            //Removes duplicate chars using string concats.
            //Store encontered lettred in this string.
            string table = "";

            //Store the result in this string.
            string result = "";

            //Loop over each character.
            foreach(char c in key)
            {
                // See if character is in the table.
                if (table.IndexOf(c) == -1)
                {
                    //Append to the and the resul
                    table += c;
                    result += c;
                }
                    

            }
            return result;
        }
        
    }

}
    

