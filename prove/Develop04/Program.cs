using System;


//Exceeding requirement will keep a log of how many times activities were performed by choosing number 4
class Program
{
    static void Main(string[] args)
    {
    
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        int choice = 0;
        Menu menu = new Menu();

        while (choice != 5) {
            Console.WriteLine();
            
            menu.ShowMenu();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing.StartActivity();
                    breathingLog = breathingLog + 1;
                    
            }
            else if (choice == 2) {
                ReflectingActivity reflecting = new ReflectingActivity("Reflection Exercise", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflecting.StartActivity();
                    reflectingLog = reflectingLog + 1;
                    
            }
            else if (choice == 3) {
                ListingActivity listing = new ListingActivity("Listing Exercise", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    listing.StartActivity();
                    listingLog = listingLog + 1;
                    
            }
            else if (choice == 4) {
                Console.WriteLine("Activity - Number of times performed in this session");
                Console.WriteLine($"Breathing Activity: {breathingLog} times");
                Console.WriteLine($"Reflecting Activity: {reflectingLog} times");
                Console.WriteLine($"Listing Activity: {listingLog} times");
            }
            else {
                Console.WriteLine("Thankyou for using the app! ");
            }
        }
            
           
    }
}