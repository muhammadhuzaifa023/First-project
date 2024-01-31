using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    public  class DuplicateArr
    {
        public static int[] DuplicateArray(int[] arr)
        {
            int size = arr.Length;
            int[] duplicatedArray = new int[size * 2];

            for (int i = 0; i < size; i++)
            {
                duplicatedArray[i] = arr[i];
                duplicatedArray[i + size] = arr[i];
            }

            return duplicatedArray;
        }

        public static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
