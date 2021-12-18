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
        p += PrintTwice;

        // we can also remove a method from the chain
        p -= PrintTwice; // this will be the last instance of it

        p("Many Prints");

        Console.WriteLine("\nour list of delegates");
        // 1 way we can check the list of delegates by looping
        foreach (var del in p.GetInvocationList())
        {
            Console.WriteLine($"{del.Method}");
        }

        // or we can do this
        Delegate[] delegates = p.GetInvocationList();
    }

    public static void PrintTwice(string message)
    {
        Console.WriteLine($"{message} PrintTwice()");
        Console.WriteLine($"{message} PrintTwice()");
    }

    public static void Print(string message)
    {
        Console.WriteLine($"{message} Print()");
    }
}