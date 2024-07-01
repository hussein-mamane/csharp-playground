using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAppConsole.obj;

namespace TestAppConsole
{
    public class ListUsage
    {
        public static void RunCode()
        {
            
            Console.WriteLine("Hello, Woorld!");
            List<int> myList = new();
            System.Console.WriteLine(myList.Capacity);
            myList.Add(5);
            // System.Console.WriteLine(myList.ToString());
            foreach (int item in myList)
            {
                System.Console.WriteLine(item+"--");
            }
            System.Console.WriteLine(myList.Count);
            System.Console.WriteLine(myList.Capacity);
            myList.Add(3);
            System.Console.WriteLine(myList.Count);
            System.Console.WriteLine(myList.Capacity);
            myList.Add(31);
            System.Console.WriteLine(myList.Count);
            System.Console.WriteLine(myList.Capacity);
            myList.Add(32);
            System.Console.WriteLine(myList.Count);
            System.Console.WriteLine(myList.Capacity);
            myList.Add(33);
            System.Console.WriteLine(myList.Count);
            System.Console.WriteLine(myList.Capacity);
            // Initial capacity 4, doubles when you try to add 5th element

            // Remove all even numbers from the list
            myList.RemoveAll(x => x % 2 == 0);

            myList.Sort(new MyComparer());//Descending Order
            foreach (int item in myList)
            {
                System.Console.Write(item+"--");
            }
            // System.Console.ReadKey();

            // 1. Add elements to the list
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.AddRange(new int[] { 4, 5, 6 });

            // 2. Remove elements from the list
            numbers.Remove(2);
            numbers.RemoveAt(2);

            // 3. Check for existence
            bool containsThree = numbers.Contains(3);

            // 4. Get the count of elements
            int count = numbers.Count;

            // 5. Get the index of an element
            int index = numbers.IndexOf(3);
            Console.WriteLine($"Index of 3: {index}"); // Output: Index of 3: 2

            // 6. Clear all elements
            numbers.Clear();

            // 7. Sort the list
            numbers.Sort();
        
            // 8. Iterate through the list
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            
            
           
            // LastIndexOf: Get the last index of an element
            int lastIndex = numbers.LastIndexOf(3);
            Console.WriteLine($"Last Index of 3: {lastIndex}"); // Output: Last Index of 3: 2

            // FindIndex: Get the index of the first element that matches a condition
            int evenIndex = numbers.FindIndex(x => x % 2 == 0);
            Console.WriteLine($"First Even Index: {evenIndex}"); // Output: First Even Index: 1

            // FindLastIndex: Get the last index of an element that matches a condition
            int lastEvenIndex = numbers.FindLastIndex(x => x % 2 == 0);
            Console.WriteLine($"Last Even Index: {lastEvenIndex}"); // Output: Last Even Index: 3
            
        }
    }
}