using System;

class T01_EnumerationTextBook
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("손준석");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"RED & {nameof(ConsoleColor.Yellow)}");
        Console.ResetColor();

        

    }
}
