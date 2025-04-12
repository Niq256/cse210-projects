using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int Bonus => _bonus;

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Goal {_shortName} completed! Earned {_points + _bonus} points.");
            }
            else
            {
                Console.WriteLine($"Recorded progress for {_shortName}. Earned {_points} points.");
            }
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

        // Showing Creativity and Exceeding Requirements
        
    private string GetProgressBar()
    {
        int barLength = 20; // Length of the progress bar
        int completedLength = (int)((double)_amountCompleted / _target * barLength);
        string progressBar = new string('#', completedLength) + new string('-', barLength - completedLength);

        return $"[{progressBar}] {_amountCompleted}/{_target}";
    }

    public override string GetDetails()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {_shortName}: {_description} ({_points} points each time, {_bonus} bonus at {_target}) - Progress: {GetProgressBar()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }
}