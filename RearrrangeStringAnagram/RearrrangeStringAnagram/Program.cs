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
            int[] numb = { 1, 2, 7, 9, 6 };
            int lastItem = numb[^1];
            Console.WriteLine(lastItem);

            //Array.Sort(aa); Array.Sort(bb);

            //Sorting without using function
            //char tempA;
            //char tempB;
            //for (int i = 0; i < aa.Length-1; i++ )
            //{
            //    for (int j = i + 1; j <= aa.Length-1; j++)
            //    {
            //        if (aa[i] > aa[j])
            //        {
            //            tempA = aa[i];
            //            aa[i] = aa[j];
            //            aa[j] = tempA;
            //        }
            //    }
            //}
            //for (int i = 0; i < bb.Length - 1; i++)
            //{
            //    for (int j = i + 1; j <= bb.Length - 1; j++)
            //    {
            //        if (bb[i] > bb[j])
            //        {
            //            tempB = bb[i];
            //            bb[i] = bb[j];
            //            bb[j] = tempB;
            //        }
            //    }
            //}

            //string sortedAA = new string(aa);      
            //Console.WriteLine(sortedAA);
            //string sortedBB = new string(bb);
            //Console.WriteLine(sortedBB);
            //if (sortedAA == sortedBB)
            //    Console.WriteLine("Passed" + "  - it is Anagram");
            //else
            //    Console.WriteLine("Failed");

            CountSort(aa,bb);
            string newAA = "";
            string newBB = "";
            int num = 100_000_000;
            
            for (int i = 0; i < aa.Length; i++)
            {
                
                newAA = char.ToString(aa[i]);
                Console.WriteLine(newAA);
            }
            Console.WriteLine(newAA + " checking");
            for (int i = 0; i < bb.Length; i++)
            {
                newBB = char.ToString(bb[i]);
                Console.WriteLine(newBB);
                Console.WriteLine(num);
                
            }
           
            if (newAA == newBB)
                Console.WriteLine("Passed" + "  - it is Anagram");
            else
                Console.WriteLine("Failed");
        }
        static void CountSort (char[]aa, char[]bb)
        {
          
            char[] aa2 = new char [aa.Length];
            int[] count = new int [256];
            for (int i = 0; i < 256; i++)
                count[i] = 0;
            for (int i = 0; i < aa.Length; i++)
                ++count[aa[i]];
            for (int i = 1; i <= 255; ++i)
                count[i] += count[i - 1];
            for (int i =  aa.Length - 1; i >= 0; i--)
            {
                aa2[count[aa[i]] - 1] = aa[i];
                    --count[aa[i]];
            }
            for (int i = 0; i < aa.Length; i++)
                aa[i] = aa2 [i];
            
    

            char[] bb2 = new char[bb.Length];
            int[] countB = new int[256];
            for (int i = 0; i < 256; i++)
                countB[i] = 0;
            for (int i = 0; i < bb.Length; i++)
                ++countB[bb[i]];
            for (int i = 1; i <= 255; ++i)
                countB[i] += countB[i - 1];
            for (int i = bb.Length - 1; i >= 0; i--)
            {
                bb2[countB[bb[i]] - 1] = bb[i];
                --countB[bb[i]];
            }
            for (int i = 0; i < bb.Length; i++)
                bb[i] = bb2[i];

        }
    }
}
