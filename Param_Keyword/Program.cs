using System;

namespace Param_Keyword
{
    internal class Program
    {
        // Method using params keyword to accept variable number of arguments
        static void Print(params string[] names)
        {
            // Iterate through each name and print it
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(); 
        }

        static void Main(string[] args)
        {
            // Different test cases with variable arguments
            Print("Kunali", "Ishwari");
            Print("Ishwari", "Mrunal", "Sonam");
            Print("Ishwari");
        }
    }
}
