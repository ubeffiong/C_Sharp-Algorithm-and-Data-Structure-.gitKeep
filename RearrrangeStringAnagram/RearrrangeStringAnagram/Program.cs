using System;

namespace RearrrangeStringAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find if the word are the same
            string firstWord = "zabk"; string secondWord = "kbza";
            char[] aa = firstWord.ToLower().ToCharArray();
            char[] bb = secondWord.ToLower().ToCharArray();
            //Array.Sort(aa); Array.Sort(bb);

            //Sorting without using function
            char tempA;
            char tempB;
            for (int i = 0; i < aa.Length-1; i++ )
            {
                for (int j = i + 1; j <= aa.Length-1; j++)
                {
                    if (aa[i] > aa[j])
                    {
                        tempA = aa[i];
                        aa[i] = aa[j];
                        aa[j] = tempA;
                    }
                }
            }
            for (int i = 0; i < bb.Length - 1; i++)
            {
                for (int j = i + 1; j <= bb.Length - 1; j++)
                {
                    if (bb[i] > bb[j])
                    {
                        tempB = bb[i];
                        bb[i] = bb[j];
                        bb[j] = tempB;
                    }
                }
            }
            string sortedAA = new string(aa);
            Console.WriteLine(sortedAA);
            string sortedBB = new string(bb);
            Console.WriteLine(sortedBB);
            if (sortedAA == sortedBB)
                Console.WriteLine("Passed" + "  - it is Anagram");
            else
                Console.WriteLine("Failed");
        }
    }
}
