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

#region Question07
// Q7: What is the 'struct' constraint? Write an example.

// Answer: The struct constraint in generics means that the type parameter must be a value type (a structure).
//         So the generic type T can only be used with types like: int, double, bool, DateTime, any custom struct
//         It cannot be used with reference types like string, class, or object.

/* 
public class ValueContainer<T> where T : struct
{
 public T Value { get; set; }

    public ValueContainer(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine(Value);
    }}
 */
#endregion

#region Question08
// Q8: What is the 'class' constraint? Write an example.

// Answer: The class constraint in generics means that the type parameter must be a reference type.
//         So the generic type T can only be: string, object, any class, arrays, interfaces
//         It cannot be a value type like int, double, or bool.

/* public class ReferenceContainer<T> where T : class
 {
    public T Data { get; set; }

    public ReferenceContainer(T data)
    {
        Data = data;
    }

    public void Display()
    {
        Console.WriteLine(Data);
    }}*/
#endregion

#region Question09
// Q9: What is the 'new()' constraint? Write an example.

// Answer: The new() constraint in generics means that the type parameter must have a public parameterless constructor.
//         This allows the generic class or method to create an object of type T using new.

/*
 public class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Factory<Student> factory = new Factory<Student>();
        Student s = factory.Create();

        Console.WriteLine("Object Created");
    }
}
 */
#endregion

#region Question10
// Q10:  What is the interface constraint? Write an example.

// Answer: The interface constraint in generics means that the type parameter must implement a specific interface.
//         This allows the generic class or method to call the interface methods safely on the type parameter.

/*
 public interface IPrintable
{
    void Print();
}

public class Printer<T> where T : IPrintable
{
    public void Show(T item)
    {
        item.Print();
    }}*/
#endregion

#region Question11
// Q11: What is the base class constraint? Write an example.

// Answer: The base class constraint in generics means that the type parameter must inherit from a specific base class.
//         This allows the generic class or method to safely use members of that base class on the type parameter.

/* Example:
 public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
public class AnimalHandler<T> where T : Animal
{
    public void Feed(T animal)
    {
        animal.Eat(); // Safe because T is guaranteed to be Animal or derived
    }
}*/
#endregion

#region Question12
// Q12: How do you apply multiple constraints? Write an example. 

// Answer: In C#, you can apply multiple constraints to a generic type parameter by separating them with commas:
//         * struct => must be a value type
//         * class => must be a reference type
//         * InterfaceName => must implement an interface
//         * BaseClassName => must inherit from a base class
//         * new() => must have a parameterless constructor

/* Example:
 
public class BaseClass
{
    public void BaseMethod()
    {
        Console.WriteLine("Base method");
    }
}

public interface IExample
{
    void ExampleMethod();
}

public class MultiConstraint<T> where T : BaseClass, IExample, new()
{
    public void UseT()
    {
        T instance = new T(); // Can create instance because of new() constraint
        instance.BaseMethod(); // Can call base class method
        instance.ExampleMethod(); // Can call interface method
    }
}
*/
#endregion

#region Question13
// Q13: What does the 'default' keyword do in generics?

// Answer: The 'default' keyword in generics is used to return the default value of a type parameter.
//         For reference types, the default value is null.
//         For value types, the default value is the zero-initialized value (e.g., 0 for int, false for bool).
//         This is very useful in generic methods or classes, where the type T is unknown at compile time.

/* Example:
 
public class Utility
{
    public static T GetDefault<T>()
    {
        return default(T);
    }
}
 */
#endregion

#region Question14
// Q14: Write a SafeList<T> that returns default when the index is invalid.

// Answer: 
/*
public class SafeList<T>
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public T Get(int index)
    {
        if (index < 0 || index >= items.Count)
        {
            return default(T); // Return default value if index is invalid
        }
        return items[index];
    }
}*/
#endregion

#region Question15
// Q15: What is covariance? Explain the 'out' keyword.

// Answer: Covariance allows a generic type to preserve inheritance relationships.
//         If Derived inherits from Base, covariance allows IEnumerable<Derived> to be used where IEnumerable<Base> is expected.
//         It only works for output (return) positions—you can read, but not write to the collection.

// The 'out' keyword is used to declare a type parameter as covariant.
// It means that the type parameter can only be used in output positions (e.g., return types) and not in input positions (e.g., method parameters).
#endregion

#region Question16
// Q16: What is contravariance? Explain the 'in' keyword.

// Answer: Contravariance is the opposite of covariance. It allows a generic type to accept less derived types.
//         If Dog inherits from Animal, contravariance allows IComparer<Animal> to be assigned to IComparer<Dog>.
//         It only works for input (parameter) positions—you can pass values into methods, but not return them

// The 'in' keyword is used to declare a type parameter as contravariant.
// It means that the type parameter can only be used in input positions (e.g., method parameters) and not in output positions (e.g., return types)
#endregion

#region Question17
// Q17: What is the difference between covariance and contravariance?

// Answer: Covariance allows a generic type to preserve the inheritance relationship for output types (e.g., return types),
//         while contravariance allows a generic type to accept less derived types for input types (e.g., method parameters).

#endregion

#region Question18
// Q18: How do static members work in generic types?

// Answer: Static members in generic types are shared across all instances of the generic type, regardless of the type parameter.
//         Each closed constructed type (e.g., Container<int>, Container<string>) has its own static members.
#endregion

#region Question19
// Q19: How can you inherit from a generic class?

// Answer: You can inherit from a generic class by specifying the type parameter in the derived class.
/*
 
public class BaseClass<T>
{
    public T Data { get; set; }
}

public class DerivedClass : BaseClass
{
    public void Display()
    {
        Console.WriteLine(Data);
    }
}
*/
#endregion