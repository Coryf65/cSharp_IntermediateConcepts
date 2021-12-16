public class Person : IComparable<Person>
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

    // The interfaces requirement, how to compare 2 people
    // Comparing by name
    public int CompareTo(Person? other)
    {
        if (other is null)
        {
            return -1;
        }

        if (this.Name.ToLower() != other.Name.ToLower())
        {
            return -1;
        }

        if (this.Name.ToLower() == other.Name.ToLower())
        {
            return 0;
        }

        return 1;
    }

    public enum Gender
    {
        Male,
        Female,
        NonBinary,
        Unknown
    }
}