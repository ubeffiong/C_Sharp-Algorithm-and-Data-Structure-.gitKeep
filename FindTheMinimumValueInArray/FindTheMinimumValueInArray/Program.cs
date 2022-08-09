using System;

namespace FindTheMinimumValueInArray
{
    //Find the minimum value in an arra
    //Implement a function findMinimum(int arr[], int size), 
    //which takes an array arr and its size and returns the smallest number in the given array.

    //For example:
        // Input: arr = [9,2,3,6]
        // Output: 2

    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[] arr = { 9, 2, 3, 6 };
            Console.Write("Array : ");
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
            int min = findMinimum(arr, size);
            Console.WriteLine("Minimum in the Array: " + min);
            return;
        }

        // Find Minimum Value in an Array
        static int findMinimum(int[] arr, int size)
        {
            int minimum = arr[0];
            //At every index compare its value with the minimum and if it is less 
            //then make that index value the new minimum value"
            for (int i = 0; i < size; i++)
            {
                if (arr[i] < minimum)
                {
                    minimum = arr[i];
                }
            }
            return minimum;
        }
    }

    //Time complexity: O(n)
    //Start with the first element(which is 9 in this example), 
    //and save it as the smallest value.Then, iterate over the rest of the array.
    //Whenever an element that is smaller than minimum is found, set minimumto that number.

    //By the end of the array, the number stored in minimum will be the smallest integer in the whole array.
}
