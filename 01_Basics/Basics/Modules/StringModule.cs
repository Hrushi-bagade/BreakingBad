using System;

public class StringModule : IPracticeModule
{
    public string Name => "Strings";

    public void ShowMenu()
    {
        Console.WriteLine("\n--- String Problems ---");
        Console.WriteLine("1. Reverse String");
        Console.WriteLine("0. Back");

        int choice = int.Parse(Console.ReadLine()!);
        Execute(choice);
    }

    public void Execute(int choice)
    {
        if (choice == 1)
            ReverseString();
    }

    void ReverseString()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine()!;
        char[] chars = input.ToCharArray();
        Array.Reverse(chars);

        Console.WriteLine("Result: " + new string(chars));
    }
}
