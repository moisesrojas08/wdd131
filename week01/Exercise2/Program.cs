using System;

Console.Write("Enter your grade percentage: ");
string input = Console.ReadLine();
int gradePercentage = int.Parse(input);

string letter = "";

if (gradePercentage >= 90)
{
    letter = "A";
}
else if (gradePercentage >= 80)
{
    letter = "B";
}
else if (gradePercentage >= 70)
{
    letter = "C";
}
else if (gradePercentage >= 60)
{
    letter = "D";
}
else
{
    letter = "F";
}

string sign = "";
int lastDigit = gradePercentage % 10;

if (lastDigit >= 7)
{
    sign = "+";
}
else if (lastDigit < 3)
{
    sign = "-";
}
else
{
    sign = ""; 
}

if (letter == "A" && sign == "+")
{
    sign = ""; // There is no A+, only A
}

if (letter == "F")
{
    sign = ""; // There is no F+ or F-, only F
}

Console.WriteLine($"Your letter grade is: {letter}{sign}");

if (gradePercentage >= 70)
{
    Console.WriteLine("Congratulations! You passed the course.");
}
else
{
    Console.WriteLine("Don't give up! Keep studying and try again next time.");
}
