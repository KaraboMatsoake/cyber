using System;

class Program
{
    static void Main(string[] args)
    {
        AudioPlayer.PlayGreeting();
        UIHelper.DisplayHeader();

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Name cannot be empty. Please enter your name: ");
            name = Console.ReadLine();
        }

        ChatBot bot = new ChatBot(name);
        bot.StartChat();
    }
}
