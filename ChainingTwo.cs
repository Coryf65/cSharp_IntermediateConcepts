public static class ChainingTwo
{
    public delegate bool CheckLengthOfString(string message);

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