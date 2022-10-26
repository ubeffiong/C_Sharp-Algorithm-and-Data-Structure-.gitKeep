using System;

namespace Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //execute methods to add max and min in an array
            int[] arr = { -1, 9, 2, 5, 3, 6, 8 }; int size = arr.Length;

            int min = findMinimum(arr, size); int max = findMax(arr, size);
            int addition = min + max;
            Console.WriteLine("Minimum + Maximum number in the Array: " + addition);
        }
        //find minimum number in an array
        static int findMinimum(int[] arr, int size)
        {
            int minimum = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < minimum)
                    minimum = arr[i];
            }
            return minimum;
        }
        //find maximum number in an array
        static int findMax(int[] arr, int size)
        {
            int max = arr[0];
            for (int i = 0; i < size; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

    }
}
