class Program
{
    static void Main(string[] args)
    {
        //Provided 2 choices for user to choose from, if user enter 3 above, program closes.
        Console.WriteLine("1. Proverbs 3:5");
        Console.WriteLine("2. John 3:15");
        Console.WriteLine("Please enter 1 or 2: ");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            string text = "Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding.";
            Scripture scripture1 = new Scripture(text);
            Reference reference1 = new Reference("Proverbs", 3, 5);
            UserInterface(scripture1,reference1);
        }
        else if (userChoice == 2)
        {
            string text = "That whosoever believeth in him should not perish, but have eternal life.";
            Scripture scripture2 = new Scripture(text);
            Reference reference2 = new Reference("John", 3, 15);
            UserInterface(scripture2,reference2);
        }
        else{
            Console.WriteLine("Invalid selection. Please run again the program. ");
        }

    static void UserInterface(Scripture scripture, Reference reference)
    {
        string userInput = "";
        do
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type quit to end the program.");
            userInput = Console.ReadLine();
            scripture.HideWords();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        } while (userInput.ToUpper() != "QUIT");
    }
    }
}