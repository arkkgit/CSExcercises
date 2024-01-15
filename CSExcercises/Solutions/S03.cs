using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExcercises.Solutions
{
    public class S03
    {

        /* create a Lsit and see the folloing oprerations
        * Add
        * Remove
        * Contains (search for an element)
        * Count
        * Clear
        */

        public static void ListPractice()
        {
            // Create a List of integers
            List<int> numbers = new List<int>();

            // Add elements to the List
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);

            Console.WriteLine("List elements after adding: ");
            PrintList(numbers);

            // Check if the List contains a specific element
            int searchElement = 3;
            bool containsElement = numbers.Contains(searchElement);
            Console.WriteLine($"List contains {searchElement}: {containsElement}");

            // Remove an element from the List
            int removeElement = 2;
            numbers.Remove(removeElement);

            Console.WriteLine($"List elements after removing {removeElement}: ");
            PrintList(numbers);

            // Get the count of elements in the List
            int count = numbers.Count;
            Console.WriteLine($"Number of elements in the List: {count}");

            // Clear all elements from the List
            numbers.Clear();

            Console.WriteLine("List elements after clearing: ");
            PrintList(numbers);
        }

        static void PrintList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

    }
}
