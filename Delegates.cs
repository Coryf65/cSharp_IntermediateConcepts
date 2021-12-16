public static class Delegates
{
    //  Setting up Delegate
    public delegate bool Filters(string item);

    public static void Example1()
    {
        Console.WriteLine("Delegates, Example1");

        string[] names = { "Alice", "John", "Bob", "Kyle", "Scott", "Todd", "Tom", "Armin", "Nina", "Billy Bob", "Jimbo", "Big Momma"};

        // we want get all names into a colleciton
        // Example we want more than 5 chars or less or equals 5
        // we don't have to make many methods we can use delegates
        List<string> lessFive = NamesFilter(names, LessThanFive); // using the Function name
        List<string> moreFive = NamesFilter(names, MoreThanFive); // using the Function name

        Console.WriteLine("Creating delegate using less than 5 filter");
        Console.WriteLine(string.Join(", ", lessFive));

        Console.WriteLine("Creating delegate using more than 5 filter");
        Console.WriteLine(string.Join(", ", moreFive));
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

    public static List<string> NamesFilter(string[] items, Filters filter)
    {
        List<string> result = new();

        foreach (var item in items)
        {
            if (filter(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}