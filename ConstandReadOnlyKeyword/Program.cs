using System;

namespace ConstAndReadOnlyKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Alice", 50000, 300);
            emp1.CalculateSalary();
            Console.WriteLine(emp1.Print());

            Employee emp2 = new Employee("Bob", 60000, 250);
            emp2.CalculateSalary();
            Console.WriteLine(emp2.Print());

            Console.WriteLine($"Total Employees: {Employee.EmpCount()}");
        }
    }

    public class Employee
    {
        // Data members
        private int id;
        private string name;
        private double basic, hra, da, pf, gross;
        private static int count;
        private const int PT = 200;  // Compile-time constant
        private readonly int PT2;    // Run-time constant (set in constructor)

        // Static constructor
        static Employee()
        {
            count = 0;  // Initialize count only once
        }

        // Constructor with PT2 as runtime constant
        public Employee(string nm, double bs, int pT2)
        {
            count++;
            id = count;
            name = nm;
            basic = bs;
            PT2 = pT2;
        }

        // Calculate employee's gross salary
        public void CalculateSalary()
        {
            hra = basic * 0.40; // 40% of basic salary
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf - PT - PT2;
        }

        // Display employee details
        public string Print()
        {
            return $"Id = {id}, Name = {name}, Gross Salary = {gross}";
        }

        // Static method to get employee count
        public static int EmpCount()
        {
            return count;
        }
    }
}
