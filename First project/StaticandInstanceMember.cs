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
        public string FirstName;
        public string Description;
        public string LastName;
        public static string schoolname = "S.M.Public Academy"; // yaa change nh hoosakta ku ka Ya static memnber haii
        // chaiya static methods hoo ya phir static members hoo unkoo hum class ka name say call kerwatay haii



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
            Console.WriteLine(Stude.schoolname);

        }

    }
}
