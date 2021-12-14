public static class Generics
{
    public static void Example1()
    {
        Console.WriteLine("Generics");
        
        Console.WriteLine($"Comparing ints");
        Console.WriteLine($"Are 1 and 2 equal ? {AreEqual(1, 2)}");
        
        Console.WriteLine($"Comparing ints");
        Console.WriteLine($"Are 5 and 5 equal ? {AreEqual(5, 5)}");

        Console.WriteLine($"Comparing strings");
        Console.WriteLine($"Are 'Cory' and 'Cory' equal ? {AreEqual("Cory", "Cory")}");
    }

    // We want this compare to work for any type
    // using the Generic type we are comparing anything of any type
    // Now we are only allow any types that implement ICompareable Interface, 'where T:IComparable<T>'
    private static bool AreEqual<T>(T num1, T num2) where T:IComparable<T>
    {
        return (num1.CompareTo(num2) == 0);
    }
}