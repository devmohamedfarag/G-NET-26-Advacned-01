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