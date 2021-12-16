public static class GenericClass
{
    public static void Example1()
    {
        Console.WriteLine("GenericClass, Example 1");
        
        Console.WriteLine("Using List as an example, we create MyList class");
        MyList<int> myints = new();

        Console.WriteLine($"Capacity {myints.Capacity}");
        Console.WriteLine($"Count {myints.Count}");

        Console.WriteLine("Adding items");
        myints.Add(1);
        myints.Add(4);
        myints.Add(10);
        myints.Add(26);
        myints.Add(8);

        Console.WriteLine($"Capacity {myints.Capacity}");
        Console.WriteLine($"Count {myints.Count}");

        
    }
}