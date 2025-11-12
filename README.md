using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExample
{
    class Employee
    {
        private string name;
        private double salary;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Зарплата не может быть отрицательной!");
                    salary = 0;
                }
                else if (value > 1_000_000)
                {
                    salary = 1_000_000;
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employee(string name, double salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public Employee(string name) : this(name, 50000)
        {
        }
        public void Work()
        {
            Console.WriteLine($"{Name} работает, зарплата: {Salary}.");
        }
    }
    class Program
    {
        static void Main()
        {
            Employee employee1 = new Employee("Иван", 80000);
            Employee employee2 = new Employee("Анна");
            employee1.Work();
            employee2.Work();
            employee1.Salary = -1000; 
            employee1.Work();
        }
    }
}
