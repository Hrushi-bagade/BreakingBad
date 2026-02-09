using System;
using System.Linq;

public static class InputHelper
{
    public static int[] ReadIntArray()
    {
        Console.Write("Enter numbers (comma separated): ");
        return Console.ReadLine()!
            .Split(',')
            .Select(int.Parse)
            .ToArray();
    }
}
