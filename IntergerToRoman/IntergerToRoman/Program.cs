using System;

namespace IntergerToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            Console.WriteLine(IntToRoman(num));
        }
        public static string IntToRoman(int num)
        {
            if (num <= 0 || num >= 3999)
            {
                //Do something
            }
            string[] thousand = { "", "M", "MM", "MMM" };
            string[] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string romanNumerals = thousand[num/1000] + hundreds[(num % 1000)/100] + tens[(num % 100)/10] + ones[num%10];
            return romanNumerals;
        }

    }
}
