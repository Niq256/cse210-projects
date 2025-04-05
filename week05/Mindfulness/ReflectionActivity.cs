using System;

public class ReflectionActivity : MindfulnessActivity
{
    private static readonly string[] Prompts =
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private static readonly string[] Questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "What could you apply from this experience to future situations?"
    };

    public ReflectionActivity(int duration) 
        : base(duration, "Reflection Activity", "This activity helps you reflect on your strength and resilience.") { }

    public override void PerformActivity()
    {
        Random random = new Random();
        Console.WriteLine(Prompts[random.Next(Prompts.Length)]);
        DateTime endTime = DateTime.Now.AddSeconds(DurationInSeconds);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(Questions[random.Next(Questions.Length)]);
            DisplayAnimation(3);
        }
    }
}