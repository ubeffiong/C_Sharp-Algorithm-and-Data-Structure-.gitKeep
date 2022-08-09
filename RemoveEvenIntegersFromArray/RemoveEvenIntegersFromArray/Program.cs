using System;

namespace RemoveEvenIntegersFromArray
{
    //Remove even integers from an array
    //Implement a function removeEven(int[] Arr, int size), 
    //which takes an array Arr and its size and removes all 
    //the even elements from the given array.

    //For example:
        // Input: Arr = [1,2,4,5,10,6,3]
        // Output: Arr = [1,5,3]

    class Program
    {
        //Remove Even Integers from an Array:
        static void Main(string[] args)
        {
            int[] arr = null;      // declaring array
            arr = new int[10];   // memory allocation
            Console.Write("Before remove even: ");
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;      // assigning values
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("");
            arr = removeEven(arr, 10);   // calling removeEven
            Console.Write("After remove even: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");    // prinitng array
            }
            Console.WriteLine("");
            return;
        }

        static int[] removeEven(int[] Arr, int size)
        {
            int m = 0;
            for (int i = 0; i < size; i++)
            {
                if (Arr[i] % 2 != 0)  // if odd number found
                {
                    Arr[m] = Arr[i];   //inserting odd values in the array
                    ++m;
                }
            }
            int[] temp = new int[m];
            for (int i = 0; i < m; i++)
                temp[i] = Arr[i];
            Arr = temp;
            return Arr;  // returning the array after removing the odd numbers
        }
    }

    //Time complexity: O(n)
    //This solution first checks if the first element of Arr is odd.
    //Then it appends this element to the start of the array Arr; 
    //otherwise, it jumps to the next element. 
    //This repeats until the end of the array Arr is reached 
    //while keeping the count of total odd numbers m in Arr.
    //Next, I make a temporary array, temp, to store all odd numbers.

    //From there, I delete the memory allocated to Arr and point it to the temp array. 
    //Lastly, I return the array Arr that is, which now contains only odd elements.
}
