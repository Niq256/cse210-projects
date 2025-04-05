using System;
using System.IO;
using System.Threading;

public abstract class MindfulnessActivity
{
    private int _durationInSeconds;
    private string _activityName;
    private string _activityDescription;

    protected MindfulnessActivity(int duration, string activityName, string activityDescription)
    {
        _durationInSeconds = duration;
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {_activityName}...\nDescription: {_activityDescription}");
        Console.WriteLine("Prepare to begin...");
        DisplayAnimation(3);
    }

    public void End()
    {
        Console.WriteLine($"Good job! You have completed the {_activityName} for {_durationInSeconds} seconds.");
        DisplayAnimation(2);
    }

    public abstract void PerformActivity();

    protected void DisplayAnimation(int duration)
    {
        for (int i = 0; i < duration; i++)
        {
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void UpdateLog()
    {
        string logFilePath = "activity_count_log.txt";

        // Read current log data or initialize
        Dictionary<string, int> activityCounts = new();
        if (File.Exists(logFilePath))
        {
            foreach (var line in File.ReadAllLines(logFilePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                {
                    activityCounts[parts[0]] = count;
                }
            }
        }

        // Update count for the performed activity
        if (activityCounts.ContainsKey(_activityName))
        {
            activityCounts[_activityName]++;
        }
        else
        {
            activityCounts[_activityName] = 1;
        }

        // Write updated log back to file
        using (StreamWriter writer = new(logFilePath, false))
        {
            foreach (var entry in activityCounts)
            {
                writer.WriteLine($"{entry.Key}:{entry.Value}");
            }
        }
    }

    protected int DurationInSeconds => _durationInSeconds;
}