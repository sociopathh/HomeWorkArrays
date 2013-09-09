/*Task 2: Write a program that reads two arrays from the console and compares them element by element.*/

using System;

class ComparingElements
{
    static void Main()
    {
        int[] arrayOne = new int[5]; 
        int[] arrayTwo = new int[5];
        bool same = true;

        Console.WriteLine("Write integers for first array.");
        for (int i = 0; i < arrayOne.Length; i++)
        {
            arrayOne[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Write integers for second array.");
        for (int i = 0; i < arrayTwo.Length; i++)
        {
            arrayTwo[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrayOne.Length; i++)
        {
            if (arrayOne[i] != arrayTwo[i])
            {
                same = false;
                break;
            }
        }
                
        if (same)
        {
            Console.WriteLine("Arrays are equal!");
        }
        else
        {
            Console.WriteLine("Arrays are not equal!");
        }
    }
}