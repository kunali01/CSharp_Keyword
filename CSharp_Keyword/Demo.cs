using System;

namespace CSharp_Keyword
{
    public class Date
    {
        // Declare data members
        private int day, year;
        private string month;

        // Constructor with a default parameter for year
        public Date(int day, string month, int year = 2024)
        {
            this.day = day; // Using 'this' keyword for data members
            this.month = month;
            this.year = year;
        }

        // Method to display the date
        public string DisplayDate()
        {
            return $"Date is: {day} / {month} / {year}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(22, "Oct"); // Year is optional; defaults to 2024
            Date d2 = new Date(23, "Feb", 2025); // Overrides the default year value

            Console.WriteLine(d1.DisplayDate());
            Console.WriteLine(d2.DisplayDate());
        }
    }
}
