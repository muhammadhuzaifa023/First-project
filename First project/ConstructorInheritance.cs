using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class Animals
    {
        public string Species;

        // Base class constructor
        public Animals(string species)
        {
            Species = species;
            Console.WriteLine($"Base class constructor called. Species: {Species}");
        }
    }

    class Dogs : Animals
    {
        public string Breed;

        // Derived class constructor
        public Dogs(string species, string breed) : base(species)
        {
            Breed = breed;
            Console.WriteLine($"Derived class constructor called. Breed: {Breed}");
        }
    }
    class ConstructorInheritance
    {
        static void Main()
        {
            // Creating an instance of the derived class
            Dogs myDog = new Dogs("Canine", "Golden Retriever");

            // Accessing properties from both base and derived classes
            Console.WriteLine($"Species: {myDog.Species}, Breed: {myDog.Breed}");
        }

    }
}
