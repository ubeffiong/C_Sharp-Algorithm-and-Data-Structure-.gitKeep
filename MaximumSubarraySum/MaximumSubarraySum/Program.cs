using System;

namespace MaximumSubarraySum
{
    //Maximum subarray sum
    //Given an unsorted array Arr, find the collection of contiguous elements 
    //that sums to the greatest value.

    //Hint: Remember that the array could contain negative numbers.
    // 1,7,-2,-5,10,11
    //1+7-2-5+10 = 11

        //use any set of array
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -4, 2, -5, 1, 2, 3, 6, -5, 1 };
            int arrSize = arr.Length;
            int maxSum = maxSumArr(arr, arrSize);
            Console.WriteLine("Maximum contiguous sum is " + maxSum);
            return;
        }
        //Maximum Sum Subarray
        static int maxSumArr (int[]arr, int arrSize)
        {
            if (arrSize <1)
            {
                return 0;
            }
            //Kadane’s algorithm in pseudocode
            int currMax = arr[0];
            int globalMax = arr[0];
            for (int i = 1; i < arrSize; i++)
            {
                if (currMax < 0)
                {
                    currMax = arr[i];
                }
                else
                {
                    currMax += arr[i];
                }
                if (globalMax < currMax)
                {
                    globalMax = currMax;
                }
            }
            return globalMax;
        } 
        
    }

    //Time complexity: O(n)

    //This solution uses Kadane’s algorithm to scan the entire array.

    //Take a look at Kadane’s algorithm in pseudocode:
    /*
    currMax = A[0]
    globalMax = A[0]
    for i = 1 -> size of A
        if currMax is less than 0
            then currMax = A[i]
        otherwise
            currMax = currMax + A[i]
        if globalMax is less than currMax
            then globalMax = currMax
    */
    /*
    At each position in the array, we find the maximum sum of the subarray ending there.
    This is achieved by keeping a currMax for the current array index and a globalMax.
    By the end, we know that the value of globalMax will be the highest subarray, 
    regardless of the value of currMax.
    */
}
