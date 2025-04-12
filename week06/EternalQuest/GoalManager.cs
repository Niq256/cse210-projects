using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet.");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetails());
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Enter the type of goal (1 - Simple, 2 - Eternal, 3 - Checklist): ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter a short name for the goal: ");
        string shortName = Console.ReadLine();

        Console.WriteLine("Enter a description for the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter points for completing this goal: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(shortName, description, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(shortName, description, points));
        }
        else if (type == "3")
        {
            Console.WriteLine("Enter the number of times to complete this goal: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points for completing this goal: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        Console.WriteLine("Enter the short name of the goal you want to record progress for: ");
        string shortName = Console.ReadLine();

        Goal goal = _goals.Find(g => g.GetDetails().Contains(shortName));
        if (goal != null)
        {
            goal.RecordEvent();
            _score += goal.Points;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Bonus;
            }
            Console.WriteLine("Event recorded successfully!");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine(_score);
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            if (line.Contains(":"))
            {
                string[] parts = line.Split(":");
                string type = parts[0];
                string[] details = parts[1].Split(",");

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                        break;
                }
            }
            else
            {
                _score = int.Parse(line);
            }
        }
    }
}