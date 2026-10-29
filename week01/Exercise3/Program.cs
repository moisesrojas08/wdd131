using System;

string playAgain = "yes";

while (playAgain.ToLower() == "yes")
{
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 101); // 101 is exclusive, so it picks 1-100

    int guess = -1;
    int attemptCount = 0;

    Console.WriteLine("I have chosen a magic number between 1 and 100. Try to guess it!");

    while (guess != magicNumber)
    {
        Console.Write("What is your guess? ");
        string input = Console.ReadLine();
        guess = int.Parse(input);
        
        attemptCount++;

        if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
    }

    Console.WriteLine($"It took you {attemptCount} guesses.");

  
    Console.Write("Do you want to play again (yes/no)? ");
    playAgain = Console.ReadLine();
    Console.WriteLine(); 
}

Console.WriteLine("Thank you for playing! Goodbye.");
