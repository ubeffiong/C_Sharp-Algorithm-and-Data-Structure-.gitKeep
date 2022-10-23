using System;

namespace IntergerPrimeNumber
{
    internal class Program
    {
        /*
         The logic is to find a positive integer less than or equal to 
        the square root of input integer. If there is a divisor of number 
        that is less than the square root of number, then there will be a 
        divisor of number that is greater than square root of number. 
        Hence, we have to traverse till the square root of number.
         */
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it's a prime Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (FindPrime(number))
                Console.WriteLine($"{number } is a Prime Number");
            else
                Console.WriteLine($"{number } is Not a Prime Number");
        }
        internal static bool FindPrime (int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var squareRoot = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= squareRoot; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
