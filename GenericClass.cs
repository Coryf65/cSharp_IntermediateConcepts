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

        Console.WriteLine($"Now we want to display items in the list");
        Console.WriteLine($"at position 2 {myints[2]}");
    }

    public static void Example2()
    {
        Console.WriteLine("GenericClass, Example 2 combine int arrays");

        MyList<int> listInts1 = new();
        MyList<int> listInts2 = new();

        listInts1.Add(45);
        listInts1.Add(50);
        listInts1.Add(78);
        listInts1.Add(45);
        listInts1.Add(88);

        listInts2.Add(1);
        listInts2.Add(4);
        listInts2.Add(10);
        listInts2.Add(26);
        listInts2.Add(8);

        MyList<int> combinedLists = listInts1 + listInts2;
        Console.WriteLine($"tostring {combinedLists.ToString()}");
            
        //Console.WriteLine($"cory string {combinedLists.CoryString(combinedLists)}");

    }

    public static void Example3()
    {
        Console.WriteLine("GenericClass, Example 2 combine string arrays");

        MyList<string> liststrings1 = new();
        MyList<string> liststrings2 = new();

        liststrings1.Add("Pear");
        liststrings1.Add("Grape");
        liststrings1.Add("Coconut");

        liststrings2.Add("Pine");
        liststrings2.Add("Oak");
        liststrings2.Add("Maple");

        MyList<string> combinedLists = liststrings1 + liststrings2;
        Console.WriteLine($"tostring {combinedLists.ToString()}");
    }
}