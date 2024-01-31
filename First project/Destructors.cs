using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
     class Destructors
    {
        public string Name;
        public string Description;
        public int Age;

        public Destructors(string  Name,string Description,int Age) {
            this.Name = Name;
            this.Description = Description;
            this.Age = Age;


            
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetDescription()
        {
            return this.Description;
        }

        public int GetAge()
        {
            return this.Age;
        }
        // Destructor may na to koi Access modifier hoota haii or na hii koi parameter pass hoota haii
        // Destructor
        ~Destructors()
        {
            Console.WriteLine("Destructor has been invoked");
        }

        static void Main(string[] args)
        {
            // Create an instance of the Destructors class
            Destructors myInstance = new Destructors("John Doe", "Some description", 25);

            // Call the methods to retrieve values
            string name = myInstance.GetName();
            string description = myInstance.GetDescription();
            int age = myInstance.GetAge();

            // Print the values
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Age: {age}");

        }
    }
}
