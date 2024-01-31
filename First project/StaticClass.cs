using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    static class Product
    {

    }
    class StaticClass

    {
        // Static class cannot be inherited or cannot be initiated with any other class .we can create this class when we cannot want to create objedct of that class.

        // Static Class can only contain Static variable and Static Method only we can not create any instance variable and any instance method 
        public static int ID;
        public static string ProductName;

        static StaticClass()
        {
            ID = 1;
            ProductName = "Telephone";
        }

        public static void GetProductDetails()
        {
            Console.WriteLine("Profduct ID {0}",ID);
            Console.WriteLine("Product Name {0}", ProductName);

        }

        static void Main(string[] args)
        {
            // cannot create instance of Static clas

            //Product  P =new Product
            StaticClass.GetProductDetails();
        }
    }
}
