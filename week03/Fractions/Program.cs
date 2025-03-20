using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing the constructors
        Fraction fraction1 = new Fraction(); // 1/1
        Fraction fraction2 = new Fraction(6); // 6/1
        Fraction fraction3 = new Fraction(6, 7); // 6/7

        // Displaying the fractions
        Console.WriteLine(fraction1.GetFractionString()); // "1/1"
        Console.WriteLine(fraction1.GetDecimalValue());

        Console.WriteLine(fraction2.GetFractionString()); // "6/1"
        Console.WriteLine(fraction2.GetDecimalValue()); 

        Console.WriteLine(fraction3.GetFractionString()); // "6/7"
        Console.WriteLine(fraction3.GetDecimalValue()); 

        // Use setters to modify the fraction
        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetFractionString()); // "3/4"
        Console.WriteLine(fraction3.GetDecimalValue()); 
    }
}