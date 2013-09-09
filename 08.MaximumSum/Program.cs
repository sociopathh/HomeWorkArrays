/* Task 8: Write a program that finds the sequence of maximal sum in given array. 
 * Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4} */

using System;

class MaximumSum
{
    static void Main(string[] args)
    {

        int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int maxSum = 0;
        int curSum = 0;
        int startInd = 0;
        int endInd = 1;
        for (int i = 0, j = 0; i < array.Length; i++)
        {
            if (array[j] <= 0)
                j++;
            else if (curSum + array[i] > maxSum)
            {
                curSum += array[i];
                maxSum = curSum;
                startInd = j;
                endInd = i;
            }
            else if ((i < array.Length - 1) && (array[i] + array[i + 1] > 0))
                curSum += array[i];
            else
            {
                curSum = 0;
                i = j;
                j++;
            }
        }

        Console.WriteLine(maxSum);
        for (int i = startInd; i <= endInd; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}