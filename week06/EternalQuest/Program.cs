using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nWelcome to the Eternal Quest Program!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Display Player Information");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Goal Event");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goalManager.DisplayPlayerInfo();
                    break;
                case "2":
                    goalManager.ListGoals();
                    break;
                case "3":
                    goalManager.CreateGoal();
                    break;
                case "4":
                    goalManager.RecordEvent();
                    break;
                case "5":
                    Console.Write("Enter filename to save goals (e.g., goals.txt): ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved successfully!");
                    break;
                case "6":
                    Console.Write("Enter filename to load goals (e.g., goals.txt): ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded successfully!");
                    break;
                case "7":
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}