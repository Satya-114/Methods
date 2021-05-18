using System;

namespace Param1
{
    class Program
    {
        static void DisplayArray(params int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 4, 5, 6 };
            DisplayArray(myArray);
            Console.WriteLine();
            DisplayArray(2, 3, 4, 5, 6, 7, 8, 9, 10);
            

        }

    }
}
    
