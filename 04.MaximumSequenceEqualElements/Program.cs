/* Task 4: Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}. */

using System;

class MaximumSequenceEqualElements
{
    static void Main(string[] args)
    {
        Console.Write("Enter the lenght of the array : ");
        int lenght = int.Parse(Console.ReadLine());
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;  
        int max = 0;  
        int element = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (max < counter)
            {
                max = counter;
                element = array[i];
            }
        }
        Console.WriteLine("The maximum sequence of equal \"{1}\" elements is: {0}", max, element);
    }
}