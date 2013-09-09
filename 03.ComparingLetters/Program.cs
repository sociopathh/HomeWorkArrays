/* Task 3: .Write a program that compares two char arrays lexicographically (letter by letter). */

using System;

class CompareLetters
{
    static void Main()
    {
        Console.WriteLine("Enter the first char elements:");
        string firstChar = Console.ReadLine();
        char[] firstArray = firstChar.ToCharArray(); //convert string to char array
        int firstArrayLength = firstArray.Length;  //gets length of the first array

        Console.WriteLine("Enter the second char elements:");
        string secondChar = Console.ReadLine();
        char[] secondArray = secondChar.ToCharArray();
        int secondArrayLength = secondArray.Length;

        int minLength = Math.Min(secondArrayLength, firstArrayLength); //gets min length of the two arrays

        bool equalCharArrays = true; 

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                continue;
            }
            else
            {
                equalCharArrays = false;
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("The first char array is lexicografically before the second.");
                }
                else
                {
                    Console.WriteLine("The second char array is lexicografically before the first.");
                }
                break;
            }
        }
        if (equalCharArrays == true && firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("The first char array is lexicografically before the second.");
        }
        else if (equalCharArrays == true && firstArrayLength > secondArrayLength)
        {
            Console.WriteLine("The second char array is lexicografically before the first.");
        }
        else if (equalCharArrays == true && firstArrayLength == secondArrayLength)
        {
            Console.WriteLine("The arrays are equal.");
        }
    }
}