using System.Drawing;

public static class ExtendClasses
{
    public static void Example1()
    {
        Console.WriteLine($"ExtendClasses, Example 1");

        // example of when you want to extend a class you cannot access or change
        Point pointOne = new(20, 30);
        Point pointTwo = new(10, 15);

        pointOne.DistanceTo(pointTwo);
        // example tell us the distance between the two points

        // can also pull the object from the return
        Distance d = pointOne.DistanceTo(pointTwo);

        Console.WriteLine(d.XDistance);
    }
}

public class Distance
{
    public int XDistance { get; set; }
    public int YDistance { get; set; }
}

public static class Extensions
{
    public static Distance DistanceTo(this Point p1, Point p2)
    {
        Console.WriteLine($"The Distance between P1 and P2 is: " +
                        $"\n{p2.X - p1.X} units in the X Direction" +
                        $"\n{p2.Y - p1.Y} units in the Y Direction");

        return new Distance() { XDistance = p2.X - p1.X, YDistance = p2.Y - p1.Y };
    }
}