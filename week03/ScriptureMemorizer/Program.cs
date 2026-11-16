using System;
using System.Collections.Generic;

/*
 * Exceeding Requirements & Creativity:
 * 1. Added a library of multiple scriptures (both single verses and verse ranges)
 *    that selects a random passage each time the program runs.
 * 2. Enhanced HideRandomWords to filter and select only from words that are still visible,
 *    avoiding redundant selections of already hidden words.
 */

class Program
{
    static void Main(string[] args)
    {
       
        List<Scripture> library =
        [
            new(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            ),
            new(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            ),
            new(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me."
            ),
            new(
                new Reference("2 Nephi", 2, 25),
                "Adam fell that men might be; and men are, that they might have joy."
            )
        ];

        Random random = new();
        Scripture currentScripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();

            if (currentScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
            {
                break;
            }

            currentScripture.HideRandomWords(3);
        }
    }
}
