using System;
using System.Collections.Generic;
using System.Linq;

namespace DNAsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dna = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT";
            var repeatedDNA = FindRepeatedDnaSequences(dna);
            foreach (var sequence in repeatedDNA)
            {
                Console.WriteLine(sequence);
            }
        }
        public static IList<string> FindRepeatedDnaSequences(string dnaSequence)
        {
            HashSet<string> SeenSequence = new HashSet<string>();
            HashSet<string> RepeatedSequence = new HashSet<string>();
            List<string> repeatedSequencesList = new List<string>();

            for (int i = 0; i <= dnaSequence.Length - 10; i++)
            {
                string subSequence = dnaSequence.Substring(i, 10);
                if (SeenSequence.Contains(subSequence))
                {
                    RepeatedSequence.Add(subSequence);
                }
                else
                {
                    SeenSequence.Add(subSequence);
                }
            }
            foreach (string subSequence in RepeatedSequence)
            {
                repeatedSequencesList.Add(subSequence);
            }
            return repeatedSequencesList;
        }
    }
}
