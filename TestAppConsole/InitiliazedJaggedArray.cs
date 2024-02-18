using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class InitiliazedJaggedArray
    {
        public static void RunCode()
        {
            // Declare the array of two elements.
            /*
            int[][] arr = new int[2][];

            // Initialize the elements.
            arr[0] = [1, 3, 5, 7, 9];
            arr[1] = [2, 4, 6, 8];

            // Display the array elements.
            for (int i = 0; i < arr.Length; i++)
            {
                System.Console.Write("Element({0}): ", i);

                for (int j = 0; j < arr[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            /* Output:
                Element(0): 1 3 5 7 9
                Element(1): 2 4 6 8
            */
        }
    }
}