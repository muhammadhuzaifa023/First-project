using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class MyCollection
    {
        private string[] data = new string[5];

        // Indexer declaration
        public string this[int index]
        {
            get
            {
                // Accessing elements using the index
                if (index >= 0 && index < data.Length)
                    return data[index];
                else
                    return "Index out of range";
            }
            set
            {
                // Setting elements using the index
                if (index >= 0 && index < data.Length)
                    data[index] = value;
                else
                    Console.WriteLine("Index out of range");
            }
        }
    }




    internal class Indexers
    {
        //Indexers provide a more generalized and flexible way to access elements within a class or structure compared to directly accessing elements in an array.
        //While arrays allow direct access using square bracket notation, indexers enable you to define custom logic for accessing elements in your own types.

        static void Main(string[] args)

        {
            MyCollection collection = new MyCollection();

            // Using the indexer to set and get values
            collection[0] = "Item 1";
            collection[1] = "Item 2";
            collection[2] = "Item 3";

            Console.WriteLine(collection[0]); // Output: Item 1
            Console.WriteLine(collection[1]); // Output: Item 2
            Console.WriteLine(collection[3]); // Output: Index out of range
            Console.WriteLine("This is Indexers Program ");
        }
    }
}
