public static class Delegates
{
    public static void Example1()
    {
        Console.WriteLine("Delegates, Example1");

        string[] names = { "Alice", "John", "Bob", "Kyle", "Scott", "Todd", "Tom", "Armin", "Nina"};

        // we want get all names into a colleciton
        // Example we want more than 5 chars or less or equals 5
        // we don't have to make many methods we can use delegates
        List<string> lessThanFiveChars = LessThanFive(names);

        Console.WriteLine(string.Join(", ", lessThanFiveChars));
    }

    public static List<string> LessThanFive(string[] items)
    {
        List<string> result = new();

        foreach (var item in items)
        {
            if (item.Length < 5)
            {
                result.Add(item);
            }
        }

        return result;
    }
}