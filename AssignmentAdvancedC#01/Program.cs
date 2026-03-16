#region Qusetion01
// Q1: What is a generic class? Why use generics?

// Answer: A generic class is a class that can work with any data type.
//         It allows you to create a class that can be used with different types without having to write separate code for each type.
//         Generics provide type safety, code reusability, and performance benefits by allowing you to define a class or method with a placeholder for the type it operates on.
#endregion

#region Qusetion02
// Q2: Write a generic class Container<T> with Add and Get methods.

// Answer:
/* 
public class Container<T>
{
    public T Item { get; private set; }

    public void Add(T item)
    {
        Item = item;
    }

    public T Get()
    {
        return Item;
    }
}*/
#endregion

#region Qusetion03
// Q3:What are multiple type parameters? Write Pair<TKey, TValue>

// Answer: Multiple type parameters allow you to define a generic class or method that can work with more than one type.
/*
 public class Pair<TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Key: {Key}, Value: {Value}");
    }
}
 */
#endregion