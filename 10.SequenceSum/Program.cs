/* Task 10: //  Write a program that finds in given array of integers a sequence of given sum S (if present).
//  Example:     {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}  */

using System;
using System.Linq;

class SequenceSum
{
    static void Main(string[] args)
    {
        int sum = 11;
        int[] arr = { 4, 3, 1, 4, 2, 5, 8, 5, 6, 3, 9, 2 };
               
        int platformSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        int count = 0;

        Console.WriteLine("The sequence with sum {0} is: ", sum);
        for (int i = 0; i < arr.Length; i++)
        {
            platformSum = 0;
            for (int j = 0 + i; j < arr.Length; j++)
            {
                platformSum += arr[j];

                if (platformSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                    count++;


                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(arr[k] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
        if (count == 0)
        {
            Console.WriteLine("There is no sequence of sum!");
        }
    }
}