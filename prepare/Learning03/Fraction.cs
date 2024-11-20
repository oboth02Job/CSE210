using System;

public class Fraction
{
    // Private attributes for numerator and denominator
    private int numerator;
    private int denominator;

    // Constructor: Initializes the fraction to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor: Initializes the fraction to numerator/1
    public Fraction(int numerator)
    {
        this.numerator = numerator;
        denominator = 1;
    }

    // Constructor: Initializes the fraction to numerator/denominator
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = value;
    }

    // Method to return the fraction as a string (e.g., 3/4)
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}