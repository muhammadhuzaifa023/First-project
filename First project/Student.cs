using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
     class Students
    {
        int RollNo;
        string? Name;  // here ? mean we can assign null vaalue to it ( int? nullableInt = null; )
        int age;
        string? Standard;

        public Students(int RollNo,string Name,int age,string Standard)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.age = age;
            this.Standard = Standard;
        }

        //public void setRollNo(int RollNo,string Name,int age,string Standard)
        //{
        //    this.RollNo = RollNo;
        //    this.Name = Name;
        //    this.age = age;
        //    this.Standard = Standard;

        //}
        //public void  getRollNo()
        //{
        //    Console.WriteLine(this.RollNo);
        //    Console.WriteLine(this.Name);
        //    Console.WriteLine(this.age);
        //    Console.WriteLine(this.Standard);
        public int getRollNo()
        {
            return this.RollNo;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getStandard() {
            return this.Standard;
        }


        //}

        static void Main(string[] args)
        {
            Students s = new Students(1, "Huzaifa", 34, "UGH");
            //s.setRollNo(1,"Huzaifa",34,"UGH");
            //s.getRollNo();

            Console.WriteLine(s.getRollNo());
            Console.WriteLine(s.getName());
            Console.WriteLine(s.getAge());
            Console.WriteLine(s.getStandard());




        }
    }
}
