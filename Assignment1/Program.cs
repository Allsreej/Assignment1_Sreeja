using System;

class Assignment1
{
    /// <summary>
    /// Name : Sreeja Alla
    /// Student ID : 8967281
    /// </summary>
    /// <param name="args"></param>

    //Main method starts here
    static void Main(string[] args)
    {
        //Welcome message for the application
        Console.WriteLine("Welcome to the Virtual Pet Simulator!");
        // To initialize pet
        Console.WriteLine("Choose your pet type (e.g.,  1. cat, " +
                                                       "2. dog," +
                                                       "3. rabbit):");
        //Enter user input
        Console.Write("User input : ");

        // Validate user input by using If-Else condition2
        if (int.TryParse(Console.ReadLine(), out int petType))
        {
            if (petType == 1)
            {
                Console.WriteLine("You have chosen a cat. What would you like to name your pet?");
            }
            else if (petType == 2)
            {
                Console.WriteLine("You have chosen a dog. What would you like to name your pet?");
            }
            else if (petType == 3)
            {
                Console.WriteLine("You have chosen a rabbit. What would you like to name your pet?");
            }
            else
            {
                Console.WriteLine("Enter a valid pet type (1, 2, or 3).");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number (1, 2, or 3).");
            return;
        }
        // Input pet name from the user
        Console.Write("User Input : ");
        string petName = Console.ReadLine();

        //Welcome message for the pet
        Console.WriteLine($"\nWelcome, {petName}! Let's take good care of him.");

        // Initialize values for the status of the pet
        int hunger = 5;
        int happiness = 5;
        int health = 8;

        // Condition
        while (true)
        {
            // To display menu for different activities
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine($"1. Feed {petName}");
            Console.WriteLine($"2. Play with {petName}");
            Console.WriteLine($"3. Let {petName} Rest ");
            Console.WriteLine($"4. Check {petName} Status");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            // If-else condition to perform different activities
            if (choice == "1")
            {
                // To feed your pet
                hunger = Math.Max(0, hunger - 1);
                happiness = Math.Max(0, happiness);
                health = Math.Min(10, health + 1);
                Console.WriteLine($"You fed {petName}.His Hunger decreases, and health improved slightly.");
            }
            else if (choice == "2")
            {
                // To play with your pet
                if (hunger >= 8)
                {
                    Console.WriteLine($"{petName} is too hungry to play! Feed them first.");
                }
                else
                {
                    happiness = Math.Min(10, happiness + 2);
                    hunger = Math.Min(10, hunger + 1);
                    health = Math.Min(10, health);

                    Console.WriteLine($"You played with {petName}.His Happiness increased, but he is a bit hungrier.");
                }
            }
            else if (choice == "3")
            {
                // Make your pet rest
                health = Math.Min(10, health + 2);
                happiness = Math.Max(1, happiness - 1);
                Console.WriteLine($"{petName} had a good rest! Health improved, but happiness slightly decreased.");
            }
            else if (choice == "4")
            {
                // To check your pet's status
                Console.WriteLine($"\n{petName}'s Status:");
                Console.WriteLine($"Hunger: {hunger}");
                Console.WriteLine($"Happiness: {happiness}");
                Console.WriteLine($"Health: {health}");

                if (hunger >= 8)
                    Console.WriteLine($"{petName} is very hungry! Please feed them soon.");
                if (happiness <= 3)
                    Console.WriteLine($"{petName} is feeling very unhappy. Try playing with them.");
                if (health <= 3)
                    Console.WriteLine($"{petName} is in poor health. Take better care of them!");
            }
            else if (choice == "5")
            {
                // To exit from the program
                Console.WriteLine("Goodbye ! Thanks for playing");
                break;
            }
            else
            {
                Console.WriteLine("Your choice is invalid. Try again.");
            }
            hunger = Math.Min(10, hunger);
            happiness = Math.Max(1, happiness);

            if (hunger == 10)
                health = Math.Max(1, health - 1);

            if (happiness <= 3)
                health = Math.Max(1, health - 1);

        }
    }
}

