using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Show number of entries");
            Console.WriteLine("6. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your answer: ");
                string text = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry entry = new Entry(date, prompt, text);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.Display();
            }
            else if (choice == "3")
            {
                journal.SaveToFile("journal.txt");
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "4")
            {
                journal.LoadFromFile("journal.txt");
                Console.WriteLine("Journal loaded.");
            }
            else if (choice == "5")
            {
                Console.WriteLine($"You have {journal.GetEntryCount()} entries.");
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }

    // Creativity: I added an option to show the number of journal entries.
}