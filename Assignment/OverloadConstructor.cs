using System;

public class Employee
{
    private int id;
    private string name;
    private double basicSalary;
    private static int count = 0;

    // Constructor with only name and basic salary
    public Employee(string name, double basicSalary)
    {
        count++;
        this.id = count; // Auto-increment ID
        this.name = name;
        this.basicSalary = basicSalary;
    }

    // Constructor with name, basic salary, and manually assigned ID
    public Employee(int id, string name, double basicSalary)
    {
        this.id = id; 
        this.name = name;
        this.basicSalary = basicSalary;
    }

    public void Print()
    {
        Console.WriteLine($"ID: {id}, Name: {name}, Basic Salary: {basicSalary}");
    }

    //static void Main(string[] args)
    //{
    //    Employee emp1 = new Employee("Kunali", 50000);
    //    Employee emp2 = new Employee(2, "Ishwari", 60000);

    //    emp1.Print();
    //    emp2.Print();
    //}
}
