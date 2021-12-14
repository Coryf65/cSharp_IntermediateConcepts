public class Person
{
    public Person(string name, int weight, int height, Gender gender)
    {
        Name = name;
        Weight = weight;
        Height = height;
        this.gender = gender;
    }

    public string Name { get; set; }   

    public int Weight { get; set; }
    public int Height { get; set; }
    public Gender gender { get; }

    public enum Gender
    {
        Male,
        Female,
        NonBinary,
        Unknown
    }
}