using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "What are things you are grateful for?",
        "Who are people that you helped this week?"
    };

    public ListingActivity(int duration) 
        : base(duration, "Listing Activity", "This activity helps you reflect on the good things in your life.") { }

    public override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        Console.WriteLine("Start listing items:");
        List<string> items = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(DurationInSeconds);
        while (DateTime.Now < endTime)
        {
            string userItem = Console.ReadLine();
            items.Add(userItem);
        }

        Console.WriteLine($"You listed {items.Count} items. Great job!");
    }
}