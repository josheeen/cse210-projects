using System;

class Program 
{
    static void Main(string[] args)
    {
        int userInput = 0;
        PrompGenerator message = new PrompGenerator();
        Journal journal = new Journal();
        Menu menu = new Menu();

        // menu.showMenu();
        // userInput = int.Parse(Console.ReadLine());
        while(userInput != 5)
        {
            menu.ShowMenu();
            userInput = int.Parse(Console.ReadLine());

            // Add Journal
            if (userInput.Equals(1))
            {
                Entry entry = new Entry();
                entry._date = DateTime.Today.ToString("MM/dd/yyyy");
                entry._prompt = message.ShowPrompt();
                Console.WriteLine(entry._prompt);
                Console.Write(">>> ");
                entry._ans = Console.ReadLine();
                journal.entries.Add(entry); // to save all the details in a LIST of instance entry
                
            }

            // Display
            else if (userInput.Equals(2))
            {   
                if (journal.entries.Count == 0)
                {   
                    Console.WriteLine();
                    Console.WriteLine("There is nothing to show. Save an entry or load a file. ");
                }
                journal.ShowJournal();
            }

            // Save file
            // File can be save using csv and txt format
            else if (userInput.Equals(3))
            {   
                // Asked user and specify the file path and name
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();

                // Create a StreamWriter object and open the file
                StreamWriter newFile = new StreamWriter(fileName);

                // Write each item in the list to the file
                foreach (Entry item in journal.entries)
                {
                    newFile.WriteLine($" :{item._date} - {item._prompt} {item._ans}");
                }

                // Close the StreamWriter
                newFile.Close();

            }

            // Load a file
            else if (userInput.Equals(4))
            {
            Console.WriteLine("Enter the name of the file: ");
            string fileName = Console.ReadLine();

            if (File.Exists(fileName))
            {
                journal.entries.Clear();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    char[] separators = {':','-','?'};
                    Entry reader = new Entry();
                    string[] parts = line.Split(separators);

                    reader._date = parts[1].Trim();
                    reader._prompt = parts[2].Trim() + '?';
                    reader._ans = parts[3].Trim();
                    journal.entries.Add(reader);
                }
            }
            }

            //exit program
            else{
                Console.WriteLine("Thank you for using Journal App!");
            }

        }
        
    }
}