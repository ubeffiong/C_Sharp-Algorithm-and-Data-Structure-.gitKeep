using System;
using System.Linq;

namespace FindEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char element;
            int Count = 0;
            int[] numbers = { 123, 2898, 13, 45676, 5, 6667, 456 };
            foreach (int i in numbers)
            {
                if (i > 0)
                {
                    Count++;
                }
                //var digitPerElement = numbers.Count(i => i > 0);
                Console.WriteLine(Count);
            }
           
            
        }
    }
}
