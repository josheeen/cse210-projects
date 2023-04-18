using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        var grade = int.Parse(Console.ReadLine());

        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You've passed. Your grade is" + " " + letter);
        }
        else
        {
            Console.WriteLine("Sorry you've failed. ");
        }
    }
}