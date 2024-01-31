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

        // Static Variable 

        public static string PersonName;
        public static int PersonAge;

        // instance variable 
        string name;
        int age;



        // Static Constructor cannot give parameter to static construtor that why static constructor cannot follow constructor overloading 
        // Access modifier bhi use nh kersaktay 
        static Stude()
        {
            PersonName = "Ali";
            PersonAge = 32;
            Console.WriteLine("This is Static constuctor Invoked");

        }


        

        //  Instance Constructor her object kaliya alag alag copy jayagiii
        // Default constructor 
        public Stude()
        {
            Console.WriteLine("This is Instance Constructor ");

        }
        // Parameterized Constructor 
        public Stude(string name,int age)
        {
            this.name = name;
            this.age = age;

        }
        // Copy Constructor
        public Stude(Stude stude)
        {
            this.name=stude.name; 
            this.age = stude.age;
        }


        //Instance Method and we use Static variable in Instance Method 
        public void GetDetails()
        {
            Console.WriteLine("This is Person Name ",PersonName);
            Console.WriteLine("This is Person Age ", PersonAge);

        }

        //Instance Method and we use Instance Variable 
        public void GetData()
        {
            Console.WriteLine("This is name : {0} ",name);
            Console.WriteLine("This is age: {0} ",age);

        }




        public static int GetfeeAnnualIncrement( int fee)  // static method kaliya object bunnay ki zoorat nh hooti 
        {

            return fee / 10 ;
        }


        // Hum instance variable koo Static methods may use nh kersatay 
        // Sird Static variable koo hii static methods may use kersaktay haiii
        // Likin Instance Methods may hum static variable use kersaktay haiii por instance variable bhi use kersaktay haii






    }
    class PrivateConstructor1
        
    {
        int age;
        // when we have private constructor then we can not make public constructor 

        // Aghr humay private constructor ka Object bunna haii to humay usmay parameterized constructor bunna pharayga 
        // jabhi uska object bunsakta haii like this 

        public PrivateConstructor1(int age)
        {
            this.age = age;
        }


        public static int a;
        // private constructor hoota haii jabhi to hum uskoo class ko kesi or say inherit nh kersaktay or nahi us class ka object bhi nh bunna saktay 
        // we only create privat constructor when we have only static members only ( weather static variable or static methods)
        public PrivateConstructor1()
        {

        }
        public static void GetDateTime()
        {
            Console.WriteLine("This is Static Method and current datetime is {0}", DateTime.Now);
        }


        //public static int Incre()
        //{

        //}
    }

    //class  PrivateConstructor2 : PrivateConstructor1
    //{
        
    //}

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

            ///-------------------------------------------------------------------
            Stude zaid = new Stude();
            zaid.GetDetails();
            //--------------------------------------------------------------------
            Stude bilal= new Stude("Bilal",19);
            bilal.GetData();
            //--------------------------------------------------------------------
            // copy constructor 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Copy Constructor");
            Stude bilal1 = new Stude(bilal);
            bilal1.GetData();

            //----------------------------------------------------------------------


            // Privatr constructor 
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("This is Private Constructor ");
            PrivateConstructor1.GetDateTime();

            // Making an object of private constructor
            Console.WriteLine("making an Object of Private Constructor ");
            PrivateConstructor1 privateConstructor1 = new PrivateConstructor1(23);
            
        }

    }
}
