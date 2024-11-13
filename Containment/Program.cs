using System;

public class Date
{
    private int day;
    private string month;
    private int year;

    public Date(int day, string month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }

    public string DisplayDate()
    {
        return $"{day} / {month} / {year}";
    }
}

public class Employee
{
    private int id;
    private string name;
    private double basic, hra, da, pf, gross;
    private static int count;
    private Date date;

    public Employee(string nm, double bs, Date date)
    {
        count++;
        id = count;
        name = nm;
        basic = bs;
        this.date = date;
    }

    public void CalculateSalary()
    {
        hra = basic * 0.40;
        da = basic * 0.20;
        pf = basic * 0.12;
        gross = (basic + hra + da) - pf;
    }

    public string Print()
    {
        return $"Id = {id}, Name = {name}, Gross salary = {gross}, Joining Date = {date.DisplayDate()}";
    }

    public static int EmpCount()
    {
        return count;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Date d1 = new Date(1, "Jan", 2025);
        Employee emp1 = new Employee("Mrunal", 45600, d1);
        emp1.CalculateSalary();
        Console.WriteLine(emp1.Print());

        Employee emp2 = new Employee("Kunali", 34000, new Date(1, "Nov", 2024));
        emp2.CalculateSalary();
        Console.WriteLine(emp2.Print());

        Console.WriteLine($"Total Employee Count: {Employee.EmpCount()}");
    }
}
