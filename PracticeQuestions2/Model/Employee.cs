using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions2.Model
{
    class Employee
    {
        public string Name { get; set; }
        public static int Salary { get; set; }
        public Employee()
        {
            Console.Write("Enter the Name of the Employee : ");
            string name = Console.ReadLine();
            Console.Write("Enter the Salary of the employee : ");
            int salary = int.Parse(Console.ReadLine());
            Name = name;
            Salary = salary;
        }
    }

    class Manager : Employee
    {
        public int Bonus { get; set; }
        public Manager() : base()
        {
            Console.Write("Enter the bonus amount : ");
            int bonus = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name of the employee :{Name}\nSalary of the employee : {Salary}");
            Bonus=bonus;
            Salary += Bonus;
            Console.WriteLine($"Salary of an employee after adding bonus : {Salary}");
        }
    }
}
