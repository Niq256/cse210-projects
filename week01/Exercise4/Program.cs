using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Collect numbers from the input
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Calculate and display the required results
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        Console.WriteLine($"\nThe sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenges
        int smallestPositive = numbers.Where(n => n > 0).DefaultIfEmpty().Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}