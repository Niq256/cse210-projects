using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 4) break;

            Console.WriteLine("Enter duration in seconds:");
            int activityDuration = int.Parse(Console.ReadLine());

            MindfulnessActivity activity = userChoice switch
            {
                1 => new BreathingActivity(activityDuration),
                2 => new ReflectionActivity(activityDuration),
                3 => new ListingActivity(activityDuration),
                _ => throw new ArgumentException("Invalid choice")
            };

            activity.Start();
            activity.PerformActivity();
            activity.End();

            // Update log for performed activity
            activity.UpdateLog();
        }
    }
}