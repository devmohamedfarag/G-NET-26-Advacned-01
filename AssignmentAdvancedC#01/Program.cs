#region Question01
// Q1: What is a generic class? Why use generics?

// Answer: A generic class is a class that can work with any data type.
//         It allows you to create a class that can be used with different types without having to write separate code for each type.
//         Generics provide type safety, code reusability, and performance benefits by allowing you to define a class or method with a placeholder for the type it operates on.
#endregion

#region Question02
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

#region Question03
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

#region Question04
// Q4: What is a generic method? Write Swap<T> method.

// Answer: A generic method is a method that can operate on any data type.
//         It allows you to define a method with a placeholder for the type it operates on.

/*
public class Utility
{
    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
*/
#endregion

#region Question05
// Q5: Write a generic method FindMax<T> that finds maximum value

// Answer
/*
public class Utility
{
    public static T FindMax<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }
}
*/
#endregion

#region Question06
// Q6: What is a generic interface? Write IRepository<T>. 

// Answer: A generic interface is an interface that uses type parameters so it can work with different data types.
//         It allows classes to implement the same interface logic but with different types.
/*
public interface IRepository<T>
{
    void Add(T item);
    T Get(int id);
    void Update(T item);
    void Delete(int id);
}
*/
#endregion