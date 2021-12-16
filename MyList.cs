/// Creating MyList based on the List Class
public class MyList<T>
{
    public int Count { get => count; private set => count = value; }
    public int Capacity { get => capacity; private set => capacity = value; }
    
    // asking for int called index
    public T this[int index]
    {
        // this is this current list
        get
        {
            // getting element at position
            return this.items[index];
        }
    }

    private T[] items;
    private int count;
    private int capacity;

    public MyList()
    {
        this.items = new T[2];
        this.capacity = 2;
        this.count = 0;
    }

    public void Add(T item)
    {
        // check if we run out of space
        if (this.capacity == this.count)
        {
            // if so we need to re init the array
            T[] clone = (T[])items.Clone();

            this.capacity *= 2; // double everytime we reach capacity
            this.items = new T[this.capacity];

            Array.Copy(clone, 0, this.items, 0, clone.Length);
        }

        // adding item to list
        this.items[this.count] = item;
        this.count++;
    }

    public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
    {
        MyList<T> result = new();

        if (list1 is null || list2 is null)
        {
            throw new NullReferenceException("Lists are of different sizes, must be the same Length");
        }

        if (list1.count != list2.count)
        {
            throw new InvalidOperationException("Lists are of different sizes, must be the same Length");
        }

        for (int i = 0; i < list1.count; i++)
        {
            result.Add((dynamic)list1[i] + (dynamic)list2[i]);
        }

        return result;
    }

    // Creating our own to string for this class
    public override string ToString()
    {
        string tempString = String.Empty;

        for (int i = 0; i < this.count; i++)
        {
            if (i < this.count - 1)
            {
                tempString += this.items[i] + ", ";
            } else
            {
                tempString += this.items[i];
            }            
        }

        return tempString; // tostring 46, 54, 88, 71, 96, remove emptys ?
        //return string.Join(", ", this.items); // tostring 46, 54, 88, 71, 96, 0, 0, 0, keep emptys
    }

    public static string CoryString(T items)
    {
        return string.Join(", ", items);
    }
}