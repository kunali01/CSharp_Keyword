using System;

public class Payment
{
    // Static method with no discount when paid in cash
    public static void PayBill(double amount)
    {
        Console.WriteLine($"Amount to be paid by cash: {amount:C}");
    }

    // Overloaded static method with 15% discount if paid by other modes
    public static void PayBill(double amount, string mode)
    {
        double discountedAmount = amount * 0.85; // Apply 15% discount
        Console.WriteLine($"Amount to be paid by {mode}: {discountedAmount:C} (after 15% discount)");
    }

    static void Main(string[] args)
    {
        // Test case 1: Paying by cash, no discount
        PayBill(1000.0);

        // Test case 2: Paying by card, 15% discount applied
        PayBill(1000.0, "Card");
    }
}
