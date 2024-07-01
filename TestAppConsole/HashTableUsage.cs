using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppConsole
{
    public class HashTableUsage
    {
        
public static void RunCode()
{
    // 1. Create a Hashtable
    Hashtable hashtable = new Hashtable();

    // 2. Add key-value pairs to the Hashtable
    hashtable.Add("John", 25);
    hashtable.Add("Alice", "Engineer");
    hashtable.Add(123, "XYZ");

    // 3. Access elements in the Hashtable using keys
    
    //FIXME  
    //just avoid non generic collection, they are not recommended by microsoft
    /*int? johnsAge = (int)hashtable["John"];
    string? alicesProfession = (string)hashtable["Alice"];
    string? xyzValue = (string)hashtable[123];*/

    // 4. Check if a key exists in the Hashtable
    bool containsAlice = hashtable.ContainsKey("Alice");
    bool containsXYZ = hashtable.ContainsKey(123);

    // 5. Check if a value exists in the Hashtable
    bool containsValue = hashtable.ContainsValue("Engineer");

    // 6. Remove key-value pairs from the Hashtable
    hashtable.Remove("Alice");

    // 7. Clear all elements from the Hashtable
    hashtable.Clear();

    // 8. Check the count of key-value pairs in the Hashtable
    int count = hashtable.Count;

    // 9. Iterate through the key-value pairs in the Hashtable
    foreach (DictionaryEntry entry in hashtable)
    {
        Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
    }

    }

    }
}