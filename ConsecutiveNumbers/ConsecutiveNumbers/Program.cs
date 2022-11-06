using System;
using System.Collections.Generic;

namespace ConsecutiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input1 = 6;
            int[] input2 = { 1, 3, 6, 2, 4, 5};
            int[] input3 = { -1, 3, 6, 9, 4, 5 };

            Console.WriteLine( "Input 2");
            if (isConsecutive(input2, input1))
                    Console.WriteLine(1);
            else
                    Console.WriteLine(0);
            Console.WriteLine("Input 3");
            if (isConsecutive(input3, input1))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
        private static bool isConsecutive(int[] input2, int input1)
        {
            Array.Sort(input2);
            // Check if all element in the array are distinct
            //traverse the array and checks if each element appears only once
            for (int i = 0; i < input2.Length - 1; i++)
            {
                if (input2[i] == input2[i + 1])
                    break;
            }

            //check if all element present in the set are consecutive
            //consecutive elements is 1
            //this will check if there is difference b/w consecutive elements in the sorted array = 1
            for (int i = 1; i < input1; i++)
                if (input2[i] - input2[i - 1] != 1)
                    return false;
            return true;
        }
        private static bool isConsecutive2(int[] input3, int input)
        {
            if (input <=1)
                return true;
            int min = input3[0];
            int max = input3[0];

            //compute the minimum and maximum element in the array
            //difference between maximum and minimum element should be input - 1
            for (int i = 1; i <input; i++)
            {
                if (input3[i] < min)
                    min = input3[i];
                if (input3[i] > max)
                    max = input3[i];
            }
            if (min - max != input - 1)
            {
                return false;
            }
            // Check if all element in the array are distinct
            //traverse the array and checks if each element appears only once
            var inputList = new HashSet<int>();
            foreach (var v in input3)
            {
                if (inputList.Contains(v))
                    return false;
                else
                    inputList.Add(v);
            }
            return true;

        }
    }

}
