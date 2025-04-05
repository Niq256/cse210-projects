using System;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int duration) 
        : base(duration, "Breathing Activity", "This activity will help you relax by guiding your breathing.") { }

    public override void PerformActivity()
    {
        for (int i = 0; i < DurationInSeconds / 4; i++)
        {
            Console.WriteLine("Breathe in...");
            DisplayAnimation(2);
            Console.WriteLine("Breathe out...");
            DisplayAnimation(2);
        }
    }
}