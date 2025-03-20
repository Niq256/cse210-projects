using System;

public class Fraction
{
    // Private attributes for numerator (top) and denominator (bottom)
    private int _top;
    private int _bottom;

    // Default constructor (1/1)
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter (e.g., 6 -> 6/1)
    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    // Constructor with two parameters (e.g., 3/4)
    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    // Getters and setters for numerator
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int numerator)
    {
        _top = numerator;
    }

    // Getters and setters for denominator
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int denominator)
    {
        _bottom = denominator;
    }

    // Method to get the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to get the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}