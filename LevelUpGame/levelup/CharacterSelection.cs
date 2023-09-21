using System;

namespace selectCharacter
{
    public class CharacterSelection
    {

        public int choice;
        public void SelectCharacter()
        {
            //Create Dictionary of values so user can input the key for the desired value
        Dictionary<int, string> characters = new Dictionary<int, string>
            {
                {1, "Red Suit Guy"},
                {2, "Blue Suit Guy"},
                {3, "Green Suit Guy"}
            };

            //1. WELCOME
            Console.WriteLine("Welcome to the Memory Maze Game!");

            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();

            // 2. Name Confirmation
            Console.WriteLine($"You've entered the name: {playerName}");
            Console.WriteLine("Is this correct? (y/n)");
            string confirmation = Console.ReadLine().ToLower();

            if (confirmation == "y")
            {
                Console.WriteLine($"Welcome {playerName}! Please choose your character!");

                // 3. Print the key-value pairs to the console
            foreach (var pair in characters)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            }
            else
            {
                Console.WriteLine("Please restart the game to enter your name.");
            }

            // 2. Name Input
            if (choice == 1)
            {
                Console.WriteLine($"{playerName}! you've chosen the {characters.Values} as your character! You're looking sharp as usual! :)");

            }
            else if (choice == 2)
            {
                Console.WriteLine($"{playerName}! you've chosen the {characters.Values} as your character! Wow, you're looking like a cool summer breeze! :)");
            }
            else
            {
                Console.WriteLine($"{playerName}! you've chosen the {characters.Values} as your character! That's different, I like it :)!");
            }
        }

    }
}
