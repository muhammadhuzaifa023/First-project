// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Program.cs

using First_project;

// Program.cs

using System;

Console.Write("Enter a positive integer: ");

// Read user input and parse it to an integer
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (PrimeNumberProgram.IsPrime(number))
    {
        Console.WriteLine($"{number} is a prime number.");
    }
    else
    {
        Console.WriteLine($"{number} is not a prime number.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid positive integer.");
}


