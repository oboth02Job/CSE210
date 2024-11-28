using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Touring the Valleys", "Nature Lover", 300);
        Video video2 = new Video("Hiking the mountains", "Jason the Hiker", 450);
        Video video3 = new Video("Tech Reviews 2024", "Gadget Geek", 600);

        // Add comments to video1
        video1.AddComment(new Comment("Job Oboth", "Amazing video!"));
        video1.AddComment(new Comment("Jackie Tanner", "I absolutely like the scenery."));
        video1.AddComment(new Comment("Hope", "Can’t wait to visit!"));

        // Add comments to video2
        video2.AddComment(new Comment("Bob", "It scares me how sketchy it looks!"));
        video2.AddComment(new Comment("Sam", "It's such a beauty over there though."));
        video2.AddComment(new Comment("Tom", "Can't wait to get there soon!"));

        // Add comments to video3
        video3.AddComment(new Comment("Thomas", "Great review!"));
        video3.AddComment(new Comment("Sharon", "Very detailed and helpful."));
        video3.AddComment(new Comment("Susan", "Keep up the good work!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display details for each video 
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetCommentText()}");
            }
            Console.WriteLine();
        }
    }
}
