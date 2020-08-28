using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> numbers = new Dictionary<string, string>();
            numbers.Add("1", "one");
            numbers.Add("2", "two");
            numbers.Add("3", "three");
            numbers.Add("4", "four");

            numbers.Add("5", null);
            numbers["5"] = "five";
            numbers.Add("6", null);
            numbers["6"] = "six";
            numbers.Remove("6");

            foreach (KeyValuePair<string, string> item in numbers)
                Console.WriteLine(string.Format("Key: {0}, Value: {1}", item.Key, item.Value));

            if (!numbers.ContainsKey("6"))
                Console.WriteLine("Key: 6, Is not found.");

            Console.ReadKey();
        }
    }
}
