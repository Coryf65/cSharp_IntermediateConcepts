using System.Linq;

public static class LinqExamples 
{
    public static void Example1()
    {
        Console.WriteLine($"LinqExamples, Example1 Running LINQ \n");
        
        // Linq and Lambdas
        int[] numbers = { 5, 6, 3, 2, 1, 5, 6, 4, 7, 8, 9, 2554, 254, 54, 14, 655, 7, 4, 3, 5, 6, 58 };

        // Linq
        var getTheNumbers = from n in numbers
                            select n;

        Console.WriteLine($"display all numbers \n");
        Console.WriteLine(string.Join(", ", getTheNumbers));

        var lessThanFive = from five in numbers
                            where five < 5
                            select five;

        // Linq is similar to a for each loop
        // Linq also executes as soon as it is called, not on initialization
        Console.WriteLine($"display all Less than 5 \n");
        Console.WriteLine(string.Join(", ", lessThanFive));
    }

    public static void Example2()
    {
        string[] catNames = { "Lucky", "Bella", "MrBig", "Ivan", "Meeka", "Fuzzball", "Oreo", "Squeaky" };

        Console.WriteLine($"LinqExamples, Example2 Linq conditions \n");

        // all
        var catsWithA = from cats in catNames
                        where cats.Contains("a")
                        select cats;

        Console.WriteLine($"display cats with the letter a in them \n");
        Console.WriteLine(string.Join(", ", catsWithA));

        var catsOrdered = from cats in catNames
                        orderby cats descending
                        select cats;

        Console.WriteLine($"display ordered cats \n");
        Console.WriteLine(string.Join(", ", catsOrdered));
    }

    public static void Example3()
    {
        Console.WriteLine($"LinqExamples, Example3 Linq with Objects \n");

        List<Person> people = new()
        {
            new Person("Jim", 180, 67, Person.Gender.Male),
            new Person("Bill", 120, 75, Person.Gender.Male),
            new Person("Ash", 220, 74, Person.Gender.Female),
            new Person("Tommy", 110, 67, Person.Gender.NonBinary),
            new Person("Socks", 202, 77, Person.Gender.NonBinary),
            new Person("James", 99, 69, Person.Gender.Male),
            new Person("John", 100, 71, Person.Gender.Male)
        };

        // all people whos name is 4 chars in length
        var fourCharPeople = from p in people
                            where p.Name.Length == 4
                            select p;

        Console.WriteLine($"all people whos name is 4 chars in length \n");
        
        foreach (var item in fourCharPeople)
        {
            Console.WriteLine(item.Name);            
        }
        
    }
}