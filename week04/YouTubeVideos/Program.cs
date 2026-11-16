using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Unboxing the New UltraBook Pro X1", "TechReviewer99", 745);
        video1.AddComment(new Comment("SarahJenkins", "Great review! The battery life looks amazing."));
        video1.AddComment(new Comment("CarlosM", "Does it run hot when editing 4K video?"));
        video1.AddComment(new Comment("DevBuilder", "Just ordered mine after watching this."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("10-Minute Morning Yoga Routine", "WellnessWithMaya", 612);
        video2.AddComment(new Comment("ElenaR", "I do this every day before work, thank you!"));
        video2.AddComment(new Comment("MarkT", "Super easy to follow for beginners."));
        video2.AddComment(new Comment("FitnessFan22", "My back feels so much better already."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Make Authentic Neapolitan Pizza at Home", "ChefMarcoKitchen", 930);
        video3.AddComment(new Comment("FoodieLife", "The dough recipe turned out crispy and delicious."));
        video3.AddComment(new Comment("LucasG", "What temperature did you set your oven to?"));
        video3.AddComment(new Comment("AnnaBell", "Best pizza tutorial on YouTube!"));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("C# Object-Oriented Programming Explained", "CodeMastery", 1180);
        video4.AddComment(new Comment("StudentCoder", "Abstraction finally makes sense now!"));
        video4.AddComment(new Comment("NetDeveloper", "Very clear examples and clean code."));
        video4.AddComment(new Comment("GraceH", "Subscribing for more C# tutorials."));
        videos.Add(video4);

        // Iterate through the list of videos and display details
        Console.WriteLine("=== YOUTUBE PRODUCT TRACKING REPORT ===\n");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
        Console.WriteLine("--------------------------------------------------");
    }
}
