using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class ArrayListUsage
    {
       
        public static void RunCode()
        {
            // 1. Create an ArrayList
            ArrayList arrayList = new ArrayList();

            // 2. Add elements to the ArrayList
            arrayList.Add(10);
            arrayList.AddRange(new int[] { 4, 5, 6 });

            // 3. Remove elements from the ArrayList
            arrayList.Remove(2); // Removes the first occurrence of 2
            arrayList.RemoveAt(2); // Removes the element at index 2

            // 4. Check for existence
            bool containsThree = arrayList.Contains(3);

            // 5. Get the count of elements
            int count = arrayList.Count;

            // 6. Get the index of an element
            int index = arrayList.IndexOf(3);
            Console.WriteLine($"Index of 3: {index}"); // Output: Index of 3: 2

            

            // 8. Sort the ArrayList
            arrayList.Sort();

            // Not advised to mix type since you will have to Cast them on reading
            arrayList.Add("Hello"); // Adding a string
            // arrayList.Add(new MyClass()); // Adding an object of a custom class



            // 9. Iterate through the ArrayList
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            // 10. LastIndexOf: Get the last index of an element
            int lastIndex = arrayList.LastIndexOf(3);
            Console.WriteLine($"Last Index of 3: {lastIndex}"); // Output: Last Index of 3: 2
            // Clear all elements
            arrayList.Clear();
            
                    

        }
    }
}