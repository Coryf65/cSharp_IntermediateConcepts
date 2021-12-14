public static class ExtensionMethods
{

    public static void Example1()
    {
        int[] array = { 1, 5, 66, 84, 10, 55, 98, 48, 18, 74, 3, 4, 7, 80, 64, 101, 8, 24, 19};

        Console.WriteLine("Bubble sort using a function");
        // a version of bubble sort
        BubbleSortFunction(array);
        Console.WriteLine(string.Join(", ", array));

        // we could have used this
        // Array.Sort();

        // Building our Extension Method, using the same method
        // available to any int array
        Console.WriteLine("Bubble sort using Extension Methods");
        array.BubbleSortExtension();
        Console.WriteLine(string.Join(", ", array));

        Console.WriteLine("Bubble sort using Extension Methods, reverse");
        array.Reverse();
        Console.WriteLine(string.Join(", ", array));
    }

    public static void BubbleSortFunction(int[] array)
    {
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int x = 0; x < array.Length - 1; x++)
            {
                if (array[x] > array[x + 1])
                {
                    temp = array[x + 1];
                    array[x + 1] = array[x];
                    array[x] = temp;
                }
            }
        }
    }

    /// Extension methods must live in a static class
    /// Building our sort into an extension method
    /// this keyword says we are extending int[], int arrays
    /// We can place this method inside a static class called Extensions.cs
    public static void BubbleSortExtension(this int[] array)
    {
        // Sorting with no reversing
        int temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int x = 0; x < array.Length - 1; x++)
            {
                if (array[x] > array[x + 1])
                {
                    temp = array[x + 1];
                    array[x + 1] = array[x];
                    array[x] = temp;
                }
            }
        }
    }

    public static void BubbleSortExtension(this int[] array, bool reverse = false)
    {
        // Sorting with optional reversing
        array.BubbleSortExtension();

        if (reverse)
        {
            Array.Reverse(array);
        }
    }

    public static void Reverse(this int[] array)
    {
        Array.Reverse(array);
    }

}