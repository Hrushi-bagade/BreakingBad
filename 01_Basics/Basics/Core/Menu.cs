using System;
using System.Collections.Generic;

public class Menu
{
    private readonly List<IPracticeModule> _modules;

    public Menu(List<IPracticeModule> modules)
    {
        _modules = modules;
    }

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== C# Basics Practice ===");
            for (int i = 0; i < _modules.Count; i++)
                Console.WriteLine($"{i + 1}. {_modules[i].Name}");

            Console.WriteLine("0. Exit");
            Console.Write("Choose a topic: ");

            int choice = int.Parse(Console.ReadLine()!);

            if (choice == 0) break;
            if (choice < 1 || choice > _modules.Count) continue;

            _modules[choice - 1].ShowMenu();
        }
    }
}
