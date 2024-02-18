using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TestAppConsole
{
    public class DictionnaryUsage
    {
        public static void RunCode()
        {
            Dictionary<int,string> myDictionary = new()
            {
                { 1, "Ali" }
            };
            myDictionary.TryAdd(0,"Bob");


            // Remove all occurrences of a value from a Dictionary
            foreach (var key in myDictionary.Keys.ToList())
            {
                if (myDictionary[key].Equals("Bob"))
                {
                    myDictionary.Remove(key);
                }
            }


            foreach (var item in myDictionary)
            {
                System.Console.WriteLine(item.Key.ToString());
                System.Console.WriteLine(item.Value);
            }
            bool containsKey = myDictionary.ContainsKey(1);
            bool containsValue = myDictionary.ContainsValue("Ali");
            int numberOfPairs = myDictionary.Count;
            string? result;
            bool success = myDictionary.TryGetValue(1, out result);
            // bool success = myDictionary.TryGetValue(1, out string? result);
            var keys = myDictionary.Keys;
            var values = myDictionary.Values;
            myDictionary.Clear();

        }
    }
}