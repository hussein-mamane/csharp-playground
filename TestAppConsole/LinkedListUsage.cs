using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class LinkedListUsage
    {
        public static void RunCode()
        {
            // Create a LinkedList<int>
            LinkedList<int> linkedList = [];//TODO to remember to keep using delightful C# v12 collection expression syntax

        // Add elements to the LinkedList
        linkedList.AddLast(10);
        linkedList.AddFirst(5);
        linkedList.AddLast(20);

        // Remove an element from the LinkedList
        linkedList.Remove(10);

        // Remove the first and last elements
        linkedList.RemoveFirst();
        linkedList.RemoveLast();

        // Check if the LinkedList contains a specific value
        bool containsValue = linkedList.Contains(5);

        // Get the number of nodes in the LinkedList
        int count = linkedList.Count;
        Console.WriteLine($"Count: {count}");

        // Clear all nodes from the LinkedList
        linkedList.Clear();

        // Add elements again for demonstration
        linkedList.AddLast(30);
        linkedList.AddLast(40);

        // Index methods
        LinkedListNode<int>? firstNode = linkedList.First;
        LinkedListNode<int>? lastNode = linkedList.Last;

        // Find a node with a specific value
        LinkedListNode<int>? foundNode = linkedList.Find(30);

        // Find the last node with a specific value
        LinkedListNode<int>? lastFoundNode = linkedList.FindLast(30);


        // Print LinkedList content
        Console.WriteLine("LinkedList elements:");
        foreach (int value in linkedList)
        {
            Console.WriteLine(value);
        }

        // Print results of operations
        Console.WriteLine($"Contains 5: {containsValue}");
        
        Console.WriteLine($"First Node: {firstNode?.Value}");
        Console.WriteLine($"Last Node: {lastNode?.Value}");
        Console.WriteLine($"Found Node: {foundNode?.Value}");
        Console.WriteLine($"Last Found Node: {lastFoundNode?.Value}");
        
        }
    }
}