using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string score = Console.ReadLine();
        int x = int.Parse(score);

        string grade = "";
        string sign = "";

        if (x >= 90)
        {
        grade = "A";
        }
        else if ((x < 90) && (x >= 80)) 
        {
        grade = "B";
        }
        else if ((x < 80) && (x >= 70)) 
        {
        grade = "C";
        }
        else if ((x < 70) && (x >= 60)) 
        {
        grade = "D";
        }
        else 
        {
        grade = "F";
        }
        
        if (grade != "A" && grade != "F")
        {
            int lastDigit = x % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }

        Console.WriteLine($"You scored grade {grade}{sign}");

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you failed. Please try again next time.");
        }
    }
}