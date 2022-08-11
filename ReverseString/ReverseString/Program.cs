using System;
using System.Linq;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Printing Method 1
            Console.WriteLine(Reverse("Hello World!"));
            //Printing Method 2
            Console.WriteLine(Reverse2("New Method 123"));
            //Printing Method 3
            Console.WriteLine(Reverse3("Most performant"));
            //Printing Method 4 - Uncommon Method Ling
            Console.WriteLine(Reverse4("Uncommon Method Ling"));
        }
        //Method 1
        public static string Reverse(string x)
        {
            string result = "";
            for (int i = x.Length - 1; i >= 0; i--)
                result += x[i];
            return result;
        }
        //Method 2 
        public static string Reverse2(string x)
        {
            var array = x.ToCharArray();
                Array.Reverse(array);
            return new string(array);
        }
        //Method 3 - Most performant
        public static string Reverse3(string x)
        {
            var result = new char[x.Length];
            var i = x.Length - 1;
            foreach (char c in x)
                result[i--] = c;
            return new string(result);
        }
        //Method 3 - Uncommon method, using Ling
        public static string Reverse4(string x)
        {
            if (x.Length == 1)
                return x;
            return x.Last() + Reverse(x.Substring(0, x.Length - 1));
        }
    }
}
