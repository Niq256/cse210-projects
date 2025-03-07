using System;

class Program
{
    static void Main(string[] args)
    {
        // PART 1

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Console.Write("What is your guess? ");
        // int guess = int.Parse(Console.ReadLine());

        // if (guess > magicNumber)
        // {
        //     Console.WriteLine("Lower");
        // }
        // else if (guess < magicNumber)
        // {
        //     Console.WriteLine("Higher");
        // }
        // else
        // {
        //     Console.WriteLine("You guessed it!");
        // }

        // PART 2

    //     Console.Write("What is the magic number? ");
    //     int magicNumber = int.Parse(Console.ReadLine());
    //     int guess = 0;

    //     while (guess != magicNumber)
    //     {
    //         Console.Write("What is your guess? ");
    //         guess = int.Parse(Console.ReadLine());

    //         if (guess < magicNumber)
    //         {
    //             Console.WriteLine("Higher");
    //         }
    //         else if (guess > magicNumber)
    //         {
    //             Console.WriteLine("Lower");
    //         }
    //         else
    //         {
    //             Console.WriteLine("You guessed it!");
    //         }
    //     }
    // }

// PART 3 and Stretch Challenge

        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101); // Random number between 1 and 100
            int guess = 0;
            int attempts = 0; // guesses

            Console.WriteLine("I have a magic number between 1 and 100. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts!");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }

}