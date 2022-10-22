// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        MyList<string> l1 = new MyList<string>();
        l1.Add("Arina");
        l1.Add("Marina");
        l1.Add("Anna");
        l1.Print();
        Console.WriteLine();
        Console.WriteLine(l1[1]);
        /*MyList<string> l2 = new MyList<string>();
        l2.Add("Nastya");
        l2.Add("Daria");
        l2.Print();*/
        Console.WriteLine(l1.Count);
    }
}
public class MyList<T>
{
    private int size = 0;

    T[] array;
    T[] helper = new T[0];
    public int Count
    {
        get { return this.size; }
    }

    public void Add(T el)
    {
        //Array.Resize<T>(ref list, size);
        size++;
        array = new T[size];
        array[size - 1] = el;
        if (helper.Length == 0)
        {
            helper = new T[size];
        }
        else
        {
            for (int i = 0; i < size - 1; i++)
            {
                array[i] = helper[i];
            }
        }
        helper = new T[size];
        for (int i = 0; i < size; i++)
        {
            helper[i] = array[i];
        }
    }
    public T this[int i]
    {
        get
        {
            return array[i];
        }

    }

    public void Print()
    {

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"{array[i]}");
        }
    }
}