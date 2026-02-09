using System;

public class ArraysModule : IPracticeModule
{
    public string Name => "Arrays";

    public void ShowMenu()
    {
        Console.WriteLine("\n--- Arrays Problems ---");
        Console.WriteLine("1. Reverse Array");
        Console.WriteLine("2. Find Max Element");
        Console.WriteLine("0. Back");

        int choice = int.Parse(Console.ReadLine()!);
        Execute(choice);
    }

    public void Execute(int choice)
    {
        switch (choice)
        {
            case 1: ReverseArray(); break;
            case 2: FindMax(); break;
        }
    }

    void ReverseArray()
    {
        int[] arr = InputHelper.ReadIntArray();
        Array.Reverse(arr);
        Console.WriteLine("Result: " + string.Join(",", arr));
    }

    void FindMax()
    {
        int[] arr = InputHelper.ReadIntArray();
        int max = arr[0];

        foreach (var n in arr)
            if (n > max) max = n;

        Console.WriteLine("Max: " + max);
    }
}
