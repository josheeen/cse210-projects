using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Welcome to guess magic number! ");

        Console.WriteLine();

        Random randomGen = new Random();
        var magicNum = randomGen.Next(1, 101);
        int userNum = 0;

        while (userNum != magicNum)
        {
            Console.Write("What is your guess? ");
            userNum = int.Parse(Console.ReadLine());
            if (userNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (userNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Congrats! You've guessed it! ");
            }
        }

        Console.WriteLine();
        


    }
}