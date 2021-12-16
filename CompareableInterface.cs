public static class CompareableInterface
{
    public static void Example1()
    {
        Console.WriteLine("CompareableInterface, Example 1");

        Person p1 = new("Jim", 0, 100, Person.Gender.NonBinary);
        Person p2 = new("Joe", 0, 100, Person.Gender.Male);
        Person p3 = new("Joe", 0, 100, Person.Gender.Male);

        Console.WriteLine($"Are {p1.Name} and {p2.Name} equal? {AreEqual(p1, p2)}");
        Console.WriteLine($"Are {p3.Name} and {p3.Name} equal? {AreEqual(p2, p3)}");
    }

    private static bool AreEqual<T>(T num1, T num2) where T:IComparable<T>
    {
        // True if they return 0
        return (num1.CompareTo(num2) == 0);
    }
}