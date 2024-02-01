using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    //  JB bhi hum sealed class bunnatay haii to woo kesi or class say inherit nh hoosaktii woo kesi or class ki Parent NH bunsaktii 

    // why we can create Sealed Classes when we have critical information of Systeminformation that we cannot inherit with other class
    // Koi bhi third party apki clas koo change nh kerpaya ya uski information koo too hum usko sealed class bunnadutay haii 
    // When you declare a class as sealed, it means that the class cannot be inherited by other classes.
    // Sealed  Methods


    
    sealed class Base
    {
        public string Name { get; set; }
    }

    //sealed class Derived : Base
    //{
    //    public int Age { get; set; }
    //}





    // In C#, the virtual keyword is used to indicate that a method or property in a base class is intended to be overridden by derived classes.
    // Sealed Method hum sirf Method overriding ka saath use kertay haii 
    // Sealed method is always an override method of sealed class.\
    // Sealed keyword can not use with method hiding.



    


    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    internal class Sealedclass
    {
        static void Main(string[] args)
        {
            //Derived derivedInstance = new Derived();
            //derivedInstance.Name = "John";
            //derivedInstance.Age = 30;

            //Console.WriteLine($"Name: {derivedInstance.Name}, Age: {derivedInstance.Age}");

            
        }
        
    }
}
