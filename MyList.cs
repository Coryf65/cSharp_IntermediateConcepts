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
}