using System;
using System.Collections.Generic;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> dic1 = new Dictionary<string, string>();
        dic1.Add("Cherednik", "Arina");
        dic1.Add("Romanova", "Nastya");
        dic1.Add("Efremova", "Irina");
        //Console.WriteLine(dic1["Cherednik"]);
        /*foreach(var el in dic1){
            Console.WriteLine(el);
        }*/


        MyDictionary<string, string> test = new MyDictionary<string, string>();
        test.Add("Cherednik", "Arina");
        test.Add("Tumanov", "Misha");
        //Console.WriteLine(test["Cherednik"]);
        foreach (var el in test)
        {
            Console.WriteLine(el);
        }
        Console.WriteLine(test.Count);
    }
}
public class MyDictionary<TKey, TValue>
{
    private int counter = 0;
    List<TKey> keys = new List<TKey>();
    List<TValue> values = new List<TValue>();
    public int Count
    {
        get { return this.counter; }
    }

    public void Add(TKey key, TValue value)
    {
        this.counter++;
        keys.Add(key);
        values.Add(value);
    }


    public TValue this[TKey key]
    {
        get
        {
            int ind = 0;
            for (int i = 0; i < keys.Count; i++)
            {
                if (key.Equals(keys[i]))
                    ind = i;
            }
            return values[ind];
        }
    }

    public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
    {
        for (int i = 0; i < keys.Count; i++)
        {
            yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
        }
    }
}