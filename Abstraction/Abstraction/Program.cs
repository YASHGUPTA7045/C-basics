using System;

namespace Abstraction
{
    class Employee
    {
        public string Name;
        public string Empid;
        public double Salary;
        public double TaxDeduction = 0.1;
        public double Grosspay;

        public Employee(string Name, string Empid, int Salary)
        {
            this.Name = Name;
            this.Empid = Empid;
            this.Salary = Salary;

        }
        void CalculateSalary()
        {
            if (Salary > 2000)
            {
                Grosspay = Salary - (Salary * TaxDeduction);
                Console.WriteLine($"the employee name is {Name} and he had got salary {Grosspay}");
            }
            else
            {
                Console.WriteLine($"the employee name is {Name} and he had got salary {Salary}");
            }
        }
        public void EmployeeDetails()
        {
            this.CalculateSalary();
        }

        class Program
        {

            static void Main(string[] args)
            {
                Employee sc = new Employee("yash", "123", 40000);
                sc.CalculateSalary();
            }
        }

    }
}
