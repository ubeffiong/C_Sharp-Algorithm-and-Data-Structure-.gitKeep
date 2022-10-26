using System;

namespace RearrrangeStringAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find if the word are the same
            string firstWord = "abk"; string secondWord = "kba";
            char[] aa = firstWord.ToLower().ToCharArray();
            char[] bb = secondWord.ToLower().ToCharArray();
            Array.Sort(aa); Array.Sort(bb);
            string sortedAA = new string(aa);
            string sortedBB = new string(bb);
            if (sortedAA == sortedBB)
                Console.WriteLine("Pass" + "  -it is anagram");
            else
                Console.WriteLine("Fail");
        }
    }
}
