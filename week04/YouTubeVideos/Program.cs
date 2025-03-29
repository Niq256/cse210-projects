using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // videos and comments
        Video video1 = new Video("Funny Cats", "Twesigye Niclous", 180);
        video1.Comments.Add(new Comment("Alice", "LOL!"));
        video1.Comments.Add(new Comment("Bobi", "Cute cats!"));
        video1.Comments.Add(new Comment("Charles", "That was hilarious!"));

        Video video2 = new Video("Cooking Tutorial", "Jane Smith", 300);
        video2.Comments.Add(new Comment("David", "Great recipe!"));
        video2.Comments.Add(new Comment("Eve", "I'll try this!"));
        video2.Comments.Add(new Comment("Frank", "Thanks for sharing!"));
        video2.Comments.Add(new Comment("Grace", "Best tutorial ever!"));

        Video video3 = new Video("Travel Vlog", "Mike Johnson", 600);
        video3.Comments.Add(new Comment("Henry", "Amazing views!"));
        video3.Comments.Add(new Comment("Ivy", "Where is this?"));
        video3.Comments.Add(new Comment("Jack", "I want to go there!"));

        Video video4 = new Video("Programming Basics", "Sarah Williams", 420);
        video4.Comments.Add(new Comment("Karen", "Very informative!"));
        video4.Comments.Add(new Comment("Liam", "This helped me a lot."));
        video4.Comments.Add(new Comment("Mia", "Clear explanation."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display video and comment information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}