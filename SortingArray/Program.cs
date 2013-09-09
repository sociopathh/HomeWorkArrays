/* Task 7: */

using System;

class SortingArray
{
    static void Main()
    {
        
        int[] myArr = new int[] { 20, 2, 10, -1, 0, -10, 16, 10, -1, 0 };

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i]);
            Console.Write(" ");
        }

        Console.WriteLine();
        int index = 0;
        for (int i = 0; i < myArr.Length; i++)
        {
            int smallest = myArr[i];
            index = i;
            for (int j = i; j < myArr.Length; j++)
            {
                if (myArr[j] < smallest)
                {
                    smallest = myArr[j];
                    index = j;
                }
            }
            myArr[index] = myArr[i];
            myArr[i] = smallest;
        }

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.Write(myArr[i]);
            Console.Write(" ");
        }
    }
}