﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    // Base class for Single Inheritance
    class PersonDeatils
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    // Interface for Interface-Based Multiple Inheritance
    interface IDriveable
    {
        void Drive();
    }
    // Class implementing the IDriveable interface
    class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Car is being driven");
        }
    }

    // Class for Hierarchical Inheritance
    class Dogs : PersonDeatils
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    // Class for Multilevel Inheritance
    class Bird : PersonDeatils
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }
    // Class combining features of both Animal and Car using Interface-Based Multiple Inheritance
    class AnimalCar : PersonDeatils, IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("AnimalCar is being driven");
        }
    }


    class TypesOfInheritance
    {
        static void Main(string[] args)
        {

            // Single Inheritance
            Dogs dog = new Dogs();
            dog.Eat();
            dog.Bark();

            // Interface-Based Multiple Inheritance
            Car car = new Car();
            car.Drive();

            // Hierarchical Inheritance
            Bird bird = new Bird();
            bird.Eat();
            bird.Fly();

            // Multilevel Inheritance
            AnimalCar animalCar = new AnimalCar();
            animalCar.Eat();
            animalCar.Drive();

        }
    }
}
