using System;

namespace CalculateFibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Recursion
            Console.WriteLine("Using Recursion");
            UsingRecursion(5);
            Console.Read();

            //Using Loop
            int number = 16; //the number of Fibaonacci elements
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            Console.WriteLine("Using Loop");
            for (int i = 2; i <= number; i++)
            {             
                Fib[i] = Fib[i - 2] + Fib[i - 1];
                Console.WriteLine(Fib[i - 2] + Fib[i - 1]);
            }
            Console.Read();      
        }
        static long UsingRecursion(int n)
        {
            if (n <= 2)
                return 1;
            else
                return UsingRecursion(n - 1) + UsingRecursion(n - 2);
        }
    }
}
