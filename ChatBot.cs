using System;

public class ChatBot
{
    private string userName;

    public ChatBot(string name)
    {
        userName = name;
    }

    public void StartChat()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nHello {userName}! I'm your Cybersecurity Awareness Bot.");
        Console.ResetColor();

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Bot: Please enter something.");
                continue;
            }

            if (input.Contains("how are you"))
                Console.WriteLine("Bot: I'm running perfectly!");
            else if (input.Contains("purpose"))
                Console.WriteLine("Bot: I help you stay safe online.");
            else if (input.Contains("password"))
                Console.WriteLine("Bot: Use strong passwords with symbols and numbers.");
            else if (input.Contains("phishing"))
                Console.WriteLine("Bot: Avoid suspicious emails asking for personal info.");
            else if (input.Contains("browsing"))
                Console.WriteLine("Bot: Always use secure websites (https).");
            else if (input.Contains("exit"))
                break;
            else
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
        }
    }
}
