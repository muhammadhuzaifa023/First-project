// See https://aka.ms/new-console-template for more information
using First_project;
using System;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Fundamentals of C-Sharp");

        Console.WriteLine("Hello, World!");

        string name = "Muhammad Huzaifa";
        int age = 23;

        // Interpolated string
        string Interpolatedmessages = $"Hello, {name}! You are {age} years old.";
        Console.WriteLine(Interpolatedmessages);

        int a = 1;
        int b = 3;
        Console.WriteLine(a + b);
        //------------------------------------------   Boxing and Unboxing  -------------------------------------------------------------------- 
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------   Boxing and Unboxing --------------------------");
        int intValue = 42;
        object boxedValue = intValue; // Boxing

        Console.WriteLine($"Original value: {intValue}");
        Console.WriteLine($"Boxed value: {boxedValue}");

        // Example of unboxing
        int unboxedValue = (int)boxedValue; // Unboxing

        Console.WriteLine($"Unboxed value: {unboxedValue}");
        //------------------------------------------  ------------------ Variable,Constant, Literal ------------------------------------------------------------------  
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------   Variable,Constant, Literal --------------------------");
        //------ All Data Types -------//
        //int Data Type
        int huzaifa; // variable Declariation
        huzaifa = 23; // variablen Initialization 
        Console.WriteLine(huzaifa);

        // Double Data Type
        double doubleValue; // Variable Declaration
        doubleValue = 3.14; // Variable Initialization
        Console.WriteLine($"Double Value: {doubleValue}");

        // Character Data Type
        char charValue; // Variable Declaration
        charValue = 'A'; // Variable Initialization
        Console.WriteLine($"Char Value: {charValue}");

        // String Data Type
        string stringValue; // Variable Declaration
        stringValue = "Hello, C#"; // Variable Initialization
        Console.WriteLine($"String Value: {stringValue}");

        // Boolean Data Type
        bool booleanValue; // Variable Declaration
        booleanValue = true; // Variable Initialization
        Console.WriteLine($"Boolean Value: {booleanValue}");

        // -------- Inferencing  -------------------//
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------   Inferencing --------------------------");
        var message = "Hello, Type Inference!";
        // The compiler infers that message is of type string
        Console.WriteLine(message);

        var c = 10;

        Console.WriteLine(c);

        //message = 123;
        //Console.WriteLine(message);
        // message = 123; // Error: Cannot implicitly convert type 'int' to 'string'

        // ---------------  const Data Type --------------------//

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------   const Data Type --------------------------");
        const int MaxValue = 100;
        const string Greeting = "Hello, Const!";
        Console.WriteLine(MaxValue + Greeting);

        // When  we use const and initialize its value then we cannot change its value again  
        //const float MaxValue = 101;
        //| Console.WriteLine(MaxValue);

        // --------------- literals -------------------------------//
        Console.WriteLine(100 + 400);
        //---------------------------------------------------------------  Operators -----------------------------------------------//
        //------------------------------------------------------------  Unary Operator -------------------------------------------- //


        // ----------------------   Pre increment and post Increment --------------- //
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------   Unary Operator --------------------------");
        int i = 5;

        // Post-increment: The current value of 'i' is used, then 'i' is incremented.
        int postIncrement = i++;
        Console.WriteLine($"Post-increment: i = {i}, postIncrement = {postIncrement}");

        // Reset 'i' to 5 for demonstration purposes
        i = 5;

        // Pre-increment: 'i' is incremented first, and then the updated value is used.
        int preIncrement = ++i;
        Console.WriteLine($"Pre-increment: i = {i}, preIncrement = {preIncrement}");

        //------------------------------------------------------------  Binary  Operator -------------------------------------------- //
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-----------------  Binary  Operator --------------------------");
        // Declare two variables for demonstration
        int d = 10;
        int e = 5;

        // Addition
        int sum = d + e;
        Console.WriteLine($"Addition: {a} + {b} = {sum}");

        // Subtraction
        int difference = d - e;
        Console.WriteLine($"Subtraction: {d} - {e} = {difference}");

        // Multiplication
        int product = d * e;
        Console.WriteLine($"Multiplication: {d} * {e} = {product}");

        // Division (integer division)
        int quotient = d / e;
        Console.WriteLine($"Division (integer): {d} / {e} = {quotient}");

        // Division (floating-point division)
        double doubleQuotient = (double)d / e;
        Console.WriteLine($"Division (floating-point): {d}  /  {e} = {doubleQuotient}");

        // Modulus (remainder after division)
        int remainder = a % b;
        Console.WriteLine($"Modulus: {d}  %  {e} = {remainder}");

        //------------------------------------------------------------  Ternary  Operator -------------------------------------------- //
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("------------------------------------------");
        // Declare a variable
        int number = 7;

        // Use the ternary operator to check if the number is even or odd
        string result = number % 2 == 0 ? "Even" : "Odd";

        Console.WriteLine($"{number} is {result}");



        //------------------------------------------------------------  Taking User Input  -------------------------------------------- //
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("--------------------  Taking User Input ----------------------");

        //// Prompt the user for input
        //Console.Write("Enter your name: ");

        //// Read user input from the console
        //string userName = Console.ReadLine();

        //// Display a message using the user input
        //Console.WriteLine($"Hello, {userName}! Welcome to C#.");

        //------------------------------------------------------------  Conditional Statements  -------------------------------------------- //
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("--------------------  Conditional Statements ( If, Else-if,Else ----------------------");
        //Console.Write("Enter a number: ");

        //// Read user input from the console
        //string userInput = Console.ReadLine();


        //if (int.TryParse(userInput, out int num)) //// Parse the user input to an integer
        //{
        //    // Check if the number is even or odd
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine($"{num} is even.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is odd.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid integer.");
        //}


        // Prompt the user to enter three numbers

        //Console.Write("Enter the first number: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter the third number: ");
        //int num3 = int.Parse(Console.ReadLine());

        //// Determine the greatest number using if, else-if, and else statements
        //if (num1 >= num2 && num1 >= num3)
        //{
        //    Console.WriteLine($"{num1} is the greatest number.");
        //}
        //else if (num2 >= num1 && num2 >= num3)
        //{
        //    Console.WriteLine($"{num2} is the greatest number.");
        //}
        //else
        //{
        //    Console.WriteLine($"{num3} is the greatest number.");
        //}

        //------------------------------------------------------------  Nested Conditional Statements  -------------------------------------------- //

        //Console.WriteLine("--------------------  Conditional Statements ( Nested Conditional Statements  ----------------------");
        // Console.Write("Enter the first number: ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //int num2 = int.Parse(Console.ReadLine());

        //Console.Write("Enter the third number: ");
        //int num3 = int.Parse(Console.ReadLine());
        //if (num1 > num2)
        //{
        //    if (num1 > num3)
        //    {
        //        Console.WriteLine("$\"{num1} is the greatest number.");

        //    }
        //    else
        //    {
        //        Console.WriteLine("$\"{num3} is the greatest number.");
        //    }
        //}
        //else

        //{
        //    if (num2 > num3)
        //    {
        //        Console.WriteLine("$\"{num2} is the greatest number.");
        //    }
        //    else { Console.WriteLine("$\"{num3} is the greatest number."); }

        //}



        //------------------------------------------------------------  == (Operator) && Equal() Method  -------------------------------------------- //
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("--------------------  == (Operator) && Equal() Method ----------------------");
        int x = 5;
        byte y = 5;

        bool areEqual1 = x == y;      // true
        bool areEqual2 = x.Equals(y);  // true
        bool areEqual3 = y.Equals(x);  // false
        Console.WriteLine(areEqual1);
        Console.WriteLine(areEqual2);
        Console.WriteLine(areEqual3);
        // The == operator returns true because the values are equal. Similarly, when we call the Equals() method on x with y as an argument, it also returns true.
        // However, when we call the Equals() method on y with x as an argument, it returns false. This is because the Equals() method checks for type compatibility before comparing the values, and in this case, x is an int and y is a byte.
        // When calling y.Equals(x), the byte value y is implicitly converted to an int, which results in a different value being compared. Therefore, the Equals() method returns false

        //------------------------------------------------------------  For Loop  -------------------------------------------- //
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("-----------------------  For Loop -------------------------");

        Console.Write("Enter a number to generate its multiplication table: ");

        if (int.TryParse(Console.ReadLine(), out int number4))
        {
            Console.Write("Enter the range for the multiplication table: ");

            if (int.TryParse(Console.ReadLine(), out int range))
            {
                Generatetable.GenerateMultiplicationTable(number4, range);
            }
            else
            {
                Console.WriteLine("Invalid input for the range. Please enter a valid integer.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for the number. Please enter a valid integer.");
        }
        //------------------------------------------------------------  Array  -------------------------------------------- //
        Console.WriteLine("------------------------------------------------- ");
        // Every Array like 1DArray,2D array,Jagged Array  contain same type element 
        // But Object array contain differentr types of Elements 
        Console.WriteLine("-----------------------  Array -------------------------");
        Console.WriteLine("---  One Dimensionn Array (1D)  ---");
        // Declare and initialize an array
        int[] numbers = { 10, 5, 8, 2, 7 };

        // Display array elements
        Console.WriteLine("Array elements:");
        foreach (int j in numbers)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("---  Two  Dimensionn Array(2D)  ---");
        // Declare and initialize an array
        int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 9, 10, 11 }, { 11, 12, 13 }, { 13, 14, 15 }, { 14, 16, 17 }, { 15, 17, 18 }, { 18, 19, 20 } };
        // Get the number of rows and columns in the 2D array
        int rows = numbers2.GetLength(0);
        int cols = numbers2.GetLength(1);
        Console.WriteLine(rows);
        Console.WriteLine(cols);

        // Display array elements using nested for loops
        for (int k = 0; k < rows; k++)
        {
            for (int r = 0; r < cols; r++)
            {
                Console.Write(numbers2[k, r] + " ");
            }
            Console.WriteLine(); // Move to the next line after each row
        }

        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("--------------------  Jagged Array ---------------------");
        // Create a jagged array
        int[][] jaggedArray = new int[3][];
        // Initialize the subarrays with different lengths
        jaggedArray[0] = new int[] { 1, 2, 3 }; /// size is 1
        jaggedArray[1] = new int[] { 4, 5, 6, 7 };/// size is 2
        jaggedArray[2] = new int[] { 8, 9 };/// size is 3

        // Display the elements of the jagged array
        for (int m = 0; m < jaggedArray.Length; m++)
        {
            for (int s = 0; s < jaggedArray[m].Length; s++)
            {
                Console.Write(jaggedArray[m][s] + " ");
            }
            Console.WriteLine(); // Move to the next line after each subarray
        }
        Console.WriteLine("------------------------------------------------- ");
        Console.WriteLine("--------------------  Object  Array ---------------------");

        object[] mixedArray = { 1, "Hello", 3.14, true, 'A' };

        // Display the elements of the object array
        Console.WriteLine("Elements of the object array:");
        foreach (var item in mixedArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("----------------------------------------------------------------------------------------- ");
        Console.WriteLine("--------------------  Basic Operatiopn On Array ---------------------");


        Console.WriteLine("Applying Sorting Builtin Function ");
        int[] arr = { 4, 2, 7, 1, 9 };
        Array.Sort(arr);

        // Using a loop to print the sorted array
        Console.Write("Sorted Array: ");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        // Or, using string.Join to concatenate array elements into a string
        string sortedArrayString = string.Join(" ", arr);
        Console.WriteLine("\nSorted Array using string.Join: " + sortedArrayString);


        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Applying Reverse Builtin Function ");
        int[] arr2 = { 4, 2, 7, 1, 9 };
        Array.Reverse(arr2);
        Console.Write("reverse Array: ");
        foreach (int num9 in arr2)
        {
            Console.Write(num9 + " ");
        }

        int[] sourceArray = { 1, 2, 3, 4, 5 };
        int[] destinationArray = new int[sourceArray.Length];
        Array.Copy(sourceArray, destinationArray, sourceArray.Length);

        //int[] numbers = { 4, 2, 7, 1, 9 };
        //int indexOfSeven = Array.IndexOf(numbers, 7);












        // ------------------------------------------------------------  Basic Code -----------------------------------------------------------------  //
        //Console.WriteLine("------------------------------------------------");
        //Console.WriteLine("------------------   Even Or ODD Program ----------------------");


        //Console.Write("Enter a number: ");

        //// Read user input from the console
        //string userInput = Console.ReadLine();
        //if (int.TryParse(userInput, out int num)) //// Parse the user input to an integer
        //{
        //    // Check if the number is even or odd
        //    if (num % 2 == 0)
        //    {
        //        Console.WriteLine($"{num} is even.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{num} is odd.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter a valid integer.");
        //}

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("--------------------------------------  Prime Number Program  ----------------------------");
        Console.Write("Enter a positive integer: ");

        if (int.TryParse(Console.ReadLine(), out int number3))
        {
            bool isPrime = PrimeNumberProgram.IsPrime1(number3);

            Console.WriteLine(isPrime ? $"{number3} is a prime number." : $"{number3} is not a prime number.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive integer.");
        }



        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("------------------   Multiplcation Of Matrix Between 2D Array Number Program  ----------------------");
        int[,] matrix1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrix2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);

        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            Console.WriteLine("Matrix multiplication is not possible.");
        }
        else
        {
            int[,] resultMatrix = MatrixMultiplication.MultiplyMatrices(matrix1, matrix2, rows1, cols1, rows2, cols2);

            Console.WriteLine("Matrix 1:");
            MatrixMultiplication.PrintMatrix(matrix1, rows1, cols1);

            Console.WriteLine("\nMatrix 2:");
            MatrixMultiplication.PrintMatrix(matrix2, rows2, cols2);

            Console.WriteLine("\nResultant Matrix (Matrix1 * Matrix2):");
            MatrixMultiplication.PrintMatrix(resultMatrix, rows1, cols2);
        }


        Console.WriteLine("------------------   Union Of Matrix Between 2D Array Number Program  ----------------------");
        int[,] resultMatrix2 = MatrixUnion.MatrixUnionVertical(matrix1, matrix2);
        MatrixMultiplication.PrintMatrix(resultMatrix2, resultMatrix2.GetLength(0), resultMatrix2.GetLength(1));

        Console.WriteLine("------------------   Find the Duplicate In the Array  ----------------------");
        Console.WriteLine("Enter the size of the array:");
        int size = Convert.ToInt32(Console.ReadLine());

        // Create an array of the specified size
        int[] originalArray = new int[size];

        // Input elements from the user
        Console.WriteLine($"Enter {size} elements:");

        for (int r = 0; i < size; i++)
        {
            Console.Write($"Element {r + 1}: ");
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Duplicate each element
        int[] duplicatedArray = DuplicateArr.DuplicateArray(originalArray);

        // Print the original and duplicated arrays
        Console.WriteLine("\nOriginal Array:");
        DuplicateArr.PrintArray(originalArray);

        Console.WriteLine("\nDuplicated Array:");
        DuplicateArr.PrintArray(duplicatedArray);


    }
}