using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{ 

    // By default class  joo hai woo internal hooti haii aghr hum usmay intrenal ka key word nh Laghay tb bhi woo by default internal hooti haiii


    // Encapculation ka sb say bhara fadiya ya hoota haii ka hum class ka private variable may hum joo data set kerwatay haii wo public methods ka through kerwatay haii 
    // hum unmay condition lagha saktay haii check kernay kaliay make a setter and getter 

    class Deatils
    {
        // Encapculation Haii private variables haii 
        private string FirstName;
        private string LastName;
        private int PersonAge;

        public void SetDetails(string FirstName,string LastName, int PersonAge)
        {
            if(string.IsNullOrEmpty(FirstName)==true && string.IsNullOrEmpty(LastName)==true)
            {
                Console.WriteLine("First Name and Last Name Cannot be Empty");
            }
            else if (PersonAge <= 0)
            {
                Console.WriteLine("Age cannot be 0 or negative. Please provide a valid age.");
            }
            else
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.PersonAge = PersonAge;


            }
            

        }
        public void GetDeatils()
        {
            Console.WriteLine("Your First Name is {0} and Last Name is {1}",this.FirstName,this.LastName);
        }



    }
    internal class Encapculation
    {
        static void Main(string[] args)
        {
            Deatils details = new Deatils();

            // SetDetails does not return anything, so you don't need to print the result
            details.SetDetails("Muhammad", "Huzaifa", 0);


            // GetDetails also does not return anything, so you don't need to print the result
            details.GetDeatils();


        }

    }
}
