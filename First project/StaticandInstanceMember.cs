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
        public static string schoolname = "S.M.Public Academy"; // yaa change nh hoosakta ku ka Ya static variable  haii
        // chaiya static methods hoo ya phir static members hoo unkoo hum class ka name say call kerwatay haii
        public static int fee = 4000;  // static  

        public static int GetfeeAnnualIncrement( int fee)  // static method kaliya object bunnay ki zoorat nh hooti 
        {

            return fee / 10 ;
        }


        // Hum instance variable koo Static methods may use nh kersatay 
        // Sird Static variable koo hii static methods may use kersaktay haiii
        // Likin Instance Methods may hum static variable use kersaktay haiii por instance variable bhi use kersaktay haii




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
            Console.WriteLine(Stude.schoolname); // static variable haii class ka name say call hoota haii
            Console.WriteLine(Stude.fee); // static variable haii class ka name say call hoota haii
            Console.WriteLine(Stude.GetfeeAnnualIncrement(3000));

        }

    }
}
