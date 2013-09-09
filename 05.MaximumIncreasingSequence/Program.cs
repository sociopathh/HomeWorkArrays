/*Task 5: Write a program that finds the maximal increasing sequence in an array. 
 * Example:  {3, 2, 3, 4, 2, 2, 4} ->{2, 3, 4}. */

using System;

class MaximumIncreasingSequence
{
    static void Main()
    {
        int[] array = { 1, 2, 13, 4, 45, 6, 7, 18, 2, 2, 4, 5, 6, 7, 2, 6 };
        int maxSequence = 0;
        int sequence = 1;
        string sequenceNumbers = "";
        string maxSequenceNumbers = "";
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                sequence++;
                sequenceNumbers += array[i] + " ";
            }
            else
            {
                if (maxSequence < sequence)
                {
                    maxSequence = sequence;
                    sequenceNumbers += array[i] + " ";
                    maxSequenceNumbers = sequenceNumbers;
                }
                sequence = 1;
                sequenceNumbers = "";
            }
        }

        if (maxSequence < sequence)
        {
            sequenceNumbers += array[array.Length - 1];
            maxSequenceNumbers = sequenceNumbers;
        }

        Console.WriteLine(maxSequenceNumbers);
    }
}