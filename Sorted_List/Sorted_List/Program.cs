using System;
using System.Collections.Generic;


namespace Sorted_List
{
    public class SortedSetExample
    {
        public static void Main(string[] args)
        {
            // create a set of strings
            var names = new SortedSet<string>();
            names.Add("Joe");
            names.Add("Bob");
            names.Add("Tim");
            names.Add("Tom");
            names.Add("Joe"); // will not be added

            // Iterate SortedSet elements using for each loop
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}