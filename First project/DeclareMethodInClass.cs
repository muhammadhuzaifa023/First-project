using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
     class DeclareMethodInClass

    {
        public void Show() // Declare method with Non-Static Keywords or instance method Non-Parametrized method 
        {
            Console.WriteLine("Hi, Cureently using C-sharp");
        }
        public static void Show1() // Declare method with Static Keywords  method Non-Parametrized method 
        {
            Console.WriteLine("Cureently using C-sharp");
        }
        static void Main(string[] args)
        {
            // calling method or instance with non static 
            DeclareMethodInClass declareMethodInClass = new();
            declareMethodInClass.Show();

            // calling static method with direct class name 
            // Calling a function 
            DeclareMethodInClass.Show1 ();
            

        }
    }
}
