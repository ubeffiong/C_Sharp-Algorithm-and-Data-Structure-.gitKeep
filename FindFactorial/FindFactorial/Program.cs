using System;

namespace FindFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Factorial of " + num + " using Recursion is: " +
                factorialUsingRecursion(5));

            Console.WriteLine("Factorial of " + num +
                " using Iteration is: " + factorialUsingIteration(5));
        }

        // ----- Using Recursion -----
        // method to find factorial of a given number
        static int factorialUsingRecursion(int n)
        {
            if (n == 0)
                return 1;
            //recursion call (using factorial formula n!=n*(n-1)!)
            return n * factorialUsingRecursion(n - 1);
        }
        // ----- Using Iteration -----
        // method to find factorial of a given number
        static int factorialUsingIteration(int n)
        {
            int res = 1, i;
            //using iteration
            for (i = 2; i <= n; i++)
                res *= i;
            return res;
        }
    }
}
