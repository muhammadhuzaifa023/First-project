using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_project
{
    class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        public string EmployeeEmail;
        public string EmployeeContactNo;

        // Constructor for Employee class
        public Employee(int employeeId, string employeeName, string employeeEmail, string employeeContactNo)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.EmployeeEmail = employeeEmail;
            this.EmployeeContactNo = employeeContactNo;
        }
    }

    class VisitingEmployee : Employee
    {
        public decimal VisitingSalary;
        public int VisitingHours;

        // Constructor for VisitingEmployee class
        public VisitingEmployee(int employeeId, string employeeName, string employeeEmail, string employeeContactNo,
                                decimal visitingSalary, int visitingHours)
            : base(employeeId, employeeName, employeeEmail, employeeContactNo)
        {
            this.VisitingSalary = visitingSalary;
            this.VisitingHours = visitingHours;
        }
    }

    class PermanentEmployee : Employee
    {
        public decimal PermanentSalary;
        public int PermanentHours;

        // Constructor for PermanentEmployee class
        public PermanentEmployee(int employeeId, string employeeName, string employeeEmail, string employeeContactNo,
                                 decimal permanentSalary, int permanentHours)
            : base(employeeId, employeeName, employeeEmail, employeeContactNo)
        {
            this.PermanentSalary = permanentSalary;
            this.PermanentHours = permanentHours;
        }
    }
    class Inheritance
    {

        static void Main(string[] args)
        {
            // Example of creating instances of VisitingEmployee and PermanentEmployee
            VisitingEmployee visitingEmp = new VisitingEmployee(1, "John Doe", "john@example.com", "123456789", 50.0m, 20);
            PermanentEmployee permanentEmp = new PermanentEmployee(2, "Jane Smith", "jane@example.com", "987654321", 5000.0m, 40);

            // You can access inherited properties from the base class
            Console.WriteLine($"Visiting Employee: {visitingEmp.EmployeeName}, Salary: {visitingEmp.VisitingSalary}, Hours: {visitingEmp.VisitingHours}");
            Console.WriteLine($"Permanent Employee: {permanentEmp.EmployeeName}, Salary: {permanentEmp.PermanentSalary}, Hours: {permanentEmp.PermanentHours}");
        }
    }
}
