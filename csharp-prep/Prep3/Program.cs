using System;

//Guess my number
/*In the Guess My Number game the computer picks a magic number, and then the user tries to guess it. 
After each guess, the computer tells the user to guess "higher" or "lower" until they guess the magic 
number.*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Welcome to guess magic number! ");

        Console.WriteLine();

        
        var response = "yes";

        while (response == "yes")
        {
            //generate a random number from 1 to 100
            Random randomGen = new Random();
            var magicNum = randomGen.Next(1, 101);

            //controller for how many tries the user did before guessing correctly
            var tries = 1;

            //Add a loop that keeps looping as long as the guess does not match the magic number.
            int userNum = 0;
            
            while (userNum != magicNum)
            {
                Console.Write("What is your guess? ");
                userNum = int.Parse(Console.ReadLine());
                if (userNum > magicNum)
                {
                    Console.WriteLine("Lower");
                    tries++;
                }
                else if (userNum < magicNum)
                {
                    Console.WriteLine("Higher");
                    tries++;
                }
                else 
                {
                    Console.WriteLine("Congrats! You've guessed it! ");
                    Console.WriteLine($"You've guess it in {tries} tries.");
                }
                
            }
            
            Console.Write("Would you like to play another round? ");
            response = Console.ReadLine();

        }
        
        Console.WriteLine("Thank you for playing GUESS MY NUMBER! ");
        Console.WriteLine();
        


    }
}