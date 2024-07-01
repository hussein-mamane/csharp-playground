using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class MultiDimensionnalArrays
    {

        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    System.Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }   
        public static void RunCode()
        {
            // in  [ comma...comma ] like [,] or [,,] style declaration , [a][b] indexing will not work
            //every dimension size MUST be given
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
            int[,] array2DDeclaration = new int[4,2 ];

            int[,,] array3DDeclaration = new int[4, 2, 3];

            // Two-dimensional array.
            int[,] array2DInitialization =  { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            // Three-dimensional array.
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                            { { 7, 8, 9 }, { 10, 11, 12 } } };

            int[][] arr2D = new int[2][];//you can only leave the rightmost dimension empty, for one dimension array you must tell it size


            // Accessing array elements.
            System.Console.WriteLine(array2DInitialization[0,0]);
            System.Console.WriteLine(array2DInitialization[0, 1]);
            System.Console.WriteLine(array2DInitialization[1, 0]);
            System.Console.WriteLine(array2DInitialization[1, 1]);

            System.Console.WriteLine(array2DInitialization[3, 0]);
            System.Console.WriteLine(array2DInitialization[3, 1]);
            // Output:
            // 1
            // 2
            // 3
            // 4
            // 7
            // 8

            System.Console.WriteLine(array3D[1, 0, 1]);
            System.Console.WriteLine(array3D[1, 1, 2]);
            // Output:
            // 8
            // 12
            int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach (int i in numbers2D)
            {
                System.Console.Write($"{i} ");
            }
            // Output: 9 99 3 33 5 55

            foreach (int i in array3D)
            {
                System.Console.Write($"{i} ");
            }
            //one by one access

            // Nested loop access    
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                for (int j = 0; j < array3D.GetLength(1); j++)
                {
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {
                        System.Console.Write($"{array3D[i, j, k]} ");
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
            }

            // Getting the total count of elements or the length of a given dimension.
            var allLength = array3D.Length;
            var total = 1;
            for (int i = 0; i < array3D.Rank; i++)
            {
                total *= array3D.GetLength(i);
            }
            System.Console.WriteLine($"{allLength} equals {total}");
            // Output:
            // 12 equals 12
        }
    }
}