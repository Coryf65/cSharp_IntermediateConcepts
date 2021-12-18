public static class Chaining
{
    public delegate void Printer(string message);

    public static void Example1()
    {
        Console.WriteLine("Chaining, Example 1");
        Printer p = Print;

        // we can call it like this
        p("some text");

        // but we can also add many methods into the delegate
        p += Print;
        p += Print;
        p += Print;
        p("Many Prints");
    }

    public static void Print(string message)
    {
        Console.WriteLine($"{message}");
    }
}