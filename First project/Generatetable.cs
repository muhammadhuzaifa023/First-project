using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    public  class Generatetable
    {
         public static void GenerateMultiplicationTable(int number, int range)
        {
            Console.WriteLine($"Multiplication table for {number} up to {range}:");

            for (int i = 1; i <= range; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }
        }
    }
}
