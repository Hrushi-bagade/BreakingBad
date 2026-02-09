using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var modules = new List<IPracticeModule>
        {
            new ArraysModule(),
            new StringModule()
        };

        new Menu(modules).Start();
    }
}
