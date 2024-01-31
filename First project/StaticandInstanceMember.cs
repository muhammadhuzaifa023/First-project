using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{

    class Stude
    {
        // by default aghr hum access modifier nh dytay to woo private hoota haii
        // c-sharp may 
        // instance member haii ku ka essay phalay static nh lagha hoya int rollno
        public int rollNo;
    }
     class StaticandInstanceMember

    {
      
        




        static void Main(string[] args)
        {
            Stude Ali = new Stude();
            Ali.rollNo = 1;
            Stude Saad = new Stude();
            Saad.rollNo = 2;
            Console.WriteLine(Ali.rollNo+ " " + Saad.rollNo);

        }
    }
}
