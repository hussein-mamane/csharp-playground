using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class ImplicitTypeArray
    {
        public static void RunCode()
        {
            int[] a = new[] { 1, 10, 100, 1000 }; // int[]

            // Accessing array
            /*Console.WriteLine("First element: " + a[0]);
            Console.WriteLine("Second element: " + a[1]);
            Console.WriteLine("Third element: " + a[2]);
            Console.WriteLine("Fourth element: " + a[3]);
            /* Outputs
            First element: 1
            Second element: 10
            Third element: 100
            Fourth element: 1000
            */

            var b = new[] { "hello", null, "world" }; // string[]

            // Accessing elements of an array using 'string.Join' method
            Console.WriteLine(string.Join(" ", b));
            /* Output
            hello  world
            */

            // single-dimension jagged array
            /*
            int[][] c =
            [
                [1,2,3,4],
                [5,6,7,8]
            ];
            // Looping through the outer array
            for (int k = 0; k < c.Length; k++)
            {
                // Looping through each inner array
                for (int j = 0; j < c[k].Length; j++)
                {
                    // Accessing each element and printing it to the console
                    Console.WriteLine($"Element at c[{k}][{j}] is: {c[k][j]}");
                }
            }
            */
            /* Outputs
            Element at c[0][0] is: 1
            Element at c[0][1] is: 2
            Element at c[0][2] is: 3
            Element at c[0][3] is: 4
            Element at c[1][0] is: 5
            Element at c[1][1] is: 6
            Element at c[1][2] is: 7
            Element at c[1][3] is: 8
            */

            // jagged array of strings
            /*
            string[][] d =
            [
                ["Luca", "Mads", "Luke", "Dinesh"],
                ["Karen", "Suma", "Frances"]
            ];*/

            // Looping through the outer array
            /*
            int i = 0;
            foreach (var subArray in d)
            {
                // Looping through each inner array
                int j = 0;
                foreach (var element in subArray)
                {
                    // Accessing each element and printing it to the console
                    Console.WriteLine($"Element at d[{i}][{j}] is: {element}");
                    j++;
                }
                i++;
            }*/
            /* Outputs
            Element at d[0][0] is: Luca
            Element at d[0][1] is: Mads
            Element at d[0][2] is: Luke
            Element at d[0][3] is: Dinesh
            Element at d[1][0] is: Karen
            Element at d[1][1] is: Suma
            Element at d[1][2] is: Frances
            */
        }
    }
}