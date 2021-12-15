public static class GenericSortingMethod
{    
    public static void Example1()
    {
        Console.WriteLine(AreEqual(true, false));

        int[] array = { 3, 4, 2, 1, 5, 6, 7, 8, 9, 2, 2, 2, 1, 23, 3 };
        string[] stringArray = { "hello", "party", "soda", "cheese" };
        
        int[] sortedArray = GenericSort(array);
        string[] sortedString = GenericSort(stringArray);

        Console.WriteLine($"GenericSortingMethod, Example 1");

        Console.WriteLine($"Our array");
        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine($"Sort int Array");
        Console.WriteLine(string.Join(", ", sortedArray));
        Console.WriteLine($"Sort string Array");
        Console.WriteLine(string.Join(", ", sortedString));
    }

    // We will change this into a generic sorting method
    public static T[] GenericSort<T>(T[] array) where T:IComparable<T>
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    T temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }                
            }
        }       
        
        return array;
    }

    public static int[] SortOriginal(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i].CompareTo(array[j]) > 0)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }                
            }
        }       
        
        return array;
    }

    private static bool AreEqual<T>(T num1, T num2) where T:IComparable<T>
    {
        return (num1.CompareTo(num2) == 0);
    }
}