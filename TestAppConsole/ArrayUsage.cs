using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class ArrayUsage
    {
        public static void RunCode()
        {
            // int[] numbers = new int[5];
            // int[] numbers = new{ 5, 2, 7, 4, 1 };
            int[] numbers = new[]{ 5, 2, 7, 4, 1 };

            Array.Sort(numbers); // Sort the array
            Console.WriteLine("Sorted Numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Array.Reverse(numbers); // Reverse the array
            Console.WriteLine("Reversed Numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        
    }
}