using System;

public class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    //static void Main(string[] args)
    //{
    //    Calculator calculator = new Calculator();

    //    Console.WriteLine("Add two integers: " + calculator.Add(5, 10));
    //    Console.WriteLine("Add three integers: " + calculator.Add(5, 10, 15));
    //    Console.WriteLine("Add two doubles: " + calculator.Add(5.5, 10.5));
    //}
}
