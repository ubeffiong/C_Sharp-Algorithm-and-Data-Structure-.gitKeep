using System;
using System.Collections.Generic;
using System.Text;

namespace StringManipulations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseString("Hello World!");
            Console.Write("Enter a Palindrome: ");
            chkPalindrome(Console.ReadLine());
            Console.Write("Enter a sentence to reverse words: ");
            ReverseWordOrder(Console.ReadLine());
            Console.Write("Enter a sentence to reverse character in each words: ");
            ReverseWords(Console.ReadLine());
            Console.Write("Enter a sentence to count character: ");
            Countcharacter(Console.ReadLine());
            Console.Write("Enter a sentence to remove character: ");
            removeduplicate(Console.ReadLine());
            Console.Write("Enter a word to find possible substring: ");
            findallsubstring(Console.ReadLine());
        }
        //How to reverse a string using two pointer method
        internal static void ReverseString (string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
        //Find if a string is a palindrome using two pointer method
        internal static void chkPalindrome (string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length -1; i < str.Length / 2; i++)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not palindrome");
        }
        //Reverse the order of words in a string
        internal static void ReverseWordOrder (string str)
        {
            int i;
            StringBuilder reverSentence = new StringBuilder();

            int Start = str.Length -1;
            int End = str.Length -1;   

            while (Start > 0)
            {
                if (str[Start] == ' ')
                {
                    i = Start + 1;
                    while (i <= End)
                    {
                        reverSentence.Append(str[i]);
                        i++;
                    }
                    reverSentence.Append(' ');
                    End = Start - 1;
                }
                Start--;
            }
            for (i = 0; i <= End; i++)
            {
                reverSentence.Append(str[i]);
            }
            Console.WriteLine(reverSentence.ToString());
        }
        //Reverse each word in a string
        internal static void ReverseWords(string str)
        {
            StringBuilder output = new StringBuilder();
            List<char> charList = new List<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ' || i == str.Length -1)
                {
                    if (i == str.Length - 1)
                        charList.Add(str[i]);
                    for(int j = charList.Count - 1; j >= 0; j--)
                        output.Append(charList[j]);

                    output.Append(' ');
                    charList = new List<char>();
                }
                else
                    charList.Add(str[i]);
            }
            Console.WriteLine(output.ToString());
        }
        //Count occurance of each character in a string
        internal static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }
        //Remove duplicate characters from a string
        internal static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }
        //All possible substring in a string
        internal static void findallsubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }
    }
}
