public static class GenericSortingMethod
{    
    public static void Example1()
    {
        Console.WriteLine(AreEqual(true, false));

        int[] array = { 3, 4, 2, 1, 5, 6, 7, 8, 9, 2, 2, 2, 1, 23, 3 };
        int[] sortedArray = Sort(array);

        Console.WriteLine($"GenericSortingMethod, Example 1");

        Console.WriteLine(string.Join(", ", array));
        Console.WriteLine(string.Join(", ", sortedArray));
    }

    public static int[] Sort(int[] array)
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