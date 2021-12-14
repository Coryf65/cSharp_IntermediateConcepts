public static class Generics
{
    public static void Example1()
    {
        Console.WriteLine("Generics");
        
        Console.WriteLine($"Are 1 and 2 equal ? {AreEqual(1, 2)}");
    }

    private static bool AreEqual(int num1, int num2)
    {
        return (num1 == num2);
    }
}