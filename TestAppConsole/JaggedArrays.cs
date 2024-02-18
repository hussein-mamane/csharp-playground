using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class JaggedArrays
    {
        public static void RunCode()
        {
            int[][] jaggedArray = new int[3][];

            // Feature 'collection expressions' is not available in C# 11.0. Please use language version 12.0 or greater.CS9058
           /* 
            jaggedArray[0] = [1, 3, 5, 7, 9];
            jaggedArray[1] = [0, 2, 4, 6];
            jaggedArray[2] = [11, 22];

            int[][] jaggedArray2 = 
            [
                [1, 3, 5, 7, 9],
                [0, 2, 4, 6],
                [11, 22]
            ];

            // Assign 77 to the second element ([1]) of the first array ([0]):
            jaggedArray2[0][1] = 77;

            // Assign 88 to the second element ([1]) of the third array ([2]):
            jaggedArray2[2][1] = 88;

            int[][,] jaggedArray3 =
            [
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            ];

            Console.Write("{0}", jaggedArray3[0][1, 0]);
            Console.WriteLine(jaggedArray3.Length);
            */
        }
    }
}