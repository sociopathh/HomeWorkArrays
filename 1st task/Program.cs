/*Task 1: Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 * Print the obtained array on the console. */

using System;


class MultipliedArrayElements
{
    static void Main()
    {
        Console.Write("How many elements your array will contain? ");  //Allocating array
        int elements = int.Parse(Console.ReadLine());
        int[] myArray = new int[elements]; 
             
          
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write("myArray[{0}] = ", i);
            myArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        
               
        for (int i = 0; i < myArray.Length; i++) 
        {
            myArray[i] =  i * 5;
            Console.Write(myArray[i] +" ");
        }
        
        Console.WriteLine();
    }
}
    

