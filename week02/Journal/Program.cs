using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string score = Console.ReadLine();
        int x = int.Parse(score);
        if (x >= 90)
        {
        Console.WriteLine("You scored grade A");
        }
        else if ((x < 90) && (x >= 80)) 
        {
        Console.WriteLine("You scored grade B");
        }
        else if ((x < 80) && (x >= 70)) 
        {
        Console.WriteLine("You scored grade C");
        }
        else if ((x < 70) && (x >= 60)) 
        {
        Console.WriteLine("You scored grade D");
        }
        else 
        Console.WriteLine("You scored grade F");
        
        if (x >= 70)
        {
            Console.WriteLine("Congradulations! you passed.");
        }
        else 
        Console.WriteLine("Unfortunately you failed. Please try again next time.");

    }
}