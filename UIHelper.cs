using System;

public static class UIHelper
{
    public static void DisplayHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================================");
        Console.WriteLine("  CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("=======================================");
        Console.WriteLine("      [LOCK] Stay Safe Online [LOCK]");
        Console.ResetColor();
    }
}
