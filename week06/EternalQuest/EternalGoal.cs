using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded {_shortName}. Earned {_points} points.");
    }

    public override bool IsComplete() => false;

    public override string GetDetails()
    {
        return $"[ ] {_shortName}: {_description} ({_points} points each time)";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}