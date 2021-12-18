using System;
using System.Collections.Generic;

public static class ChainingTwo
{
    public delegate bool CheckLengthOfString(string message);
    public delegate int GetLengths(string message);

    public static void Example1()
    {
        Console.WriteLine("\nChainingTwo, Example1");
        CheckLengthOfString d = LessThanFive;

        d += MoreThanFive;
        d += EqualsFive;

        Console.WriteLine(d("Message"));

        List<bool> results = new();

        foreach (var del in d.GetInvocationList())
        {
            results.Add((bool)del.DynamicInvoke("Message"));
        }

        Console.WriteLine("display using this way");
        Console.WriteLine(string.Join(", ", results));

        Console.WriteLine("\nor this way using a lambda");
        List<bool> results2 = d.GetInvocationList().Select(d => (bool)d.DynamicInvoke("Message")).ToList();
        Console.WriteLine(string.Join(", ", results2));

        Console.WriteLine("\nbuild a function for ease");
        List<bool> results3 = GatherAllMethodsOfDel<bool>(d, "Function!");
        Console.WriteLine(string.Join(", ", results3));

        GetLengths g = x => x.Length;
        g += x => x.Length + 1;
        g += x => x.Length + 2;

        Console.WriteLine("\nnow using an int");
        List<int> results4 = GatherAllMethodsOfDel<int>(g, "Some words");
        Console.WriteLine(string.Join(", ", results4));
    }

    // replacing the long call into a mehtod
    // d.GetInvocationList().Select(d => (bool)d.DynamicInvoke("Message")).ToList();
    public static List<T> GatherAllMethodsOfDel<T>(Delegate del, object parameter = null)
    {
        List<T> result = del.GetInvocationList()
                            .Select(d => (T)d.DynamicInvoke(parameter))
                            .ToList();
        return result;
    }

    public static bool LessThanFive(string name)
    {
        return name.Length < 5;
    }

    public static bool MoreThanFive(string name)
    {
        return name.Length > 5;
    }

    public static bool EqualsFive(string name)
    {
        return name.Length == 5;
    }
}