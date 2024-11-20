using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing all three constructors
        Fraction fraction1 = new Fraction();       // 1/1
        Fraction fraction2 = new Fraction(5);      // 5/1
        Fraction fraction3 = new Fraction(3, 4);   // 3/4
        Fraction fraction4 = new Fraction(1, 3);   // 1/3

        // Display results using required methods
        DisplayFractionDetails(fraction1);
        DisplayFractionDetails(fraction2);
        DisplayFractionDetails(fraction3);
        DisplayFractionDetails(fraction4);

        // Test getters and setters
        Fraction testFraction = new Fraction();
        testFraction.SetNumerator(7);
        testFraction.SetDenominator(2);

        Console.WriteLine("Updated Fraction:");
        Console.WriteLine($"Fraction: {testFraction.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {testFraction.GetDecimalValue()}");
    }

    // Method to display fraction details
    static void DisplayFractionDetails(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}