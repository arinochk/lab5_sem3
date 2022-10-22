// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello Mono World");
        Matrix m1 = new Matrix();
        m1.Print();
        m1.ChangeSize(4, 4);
        m1.Print();
    }
}

public class Matrix
{
    int n, m, r, l;
    int[,] A;

    public Matrix()
    {
        Console.WriteLine("Введите n");
        n = 4;
        Console.WriteLine("Введите m");
        m = 3;
        Console.WriteLine("Введите l");
        l = 1;
        Console.WriteLine("Введите r");
        r = 10;
        A = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                A[i, j] = rnd.Next(l, r);
            }
        }
    }

    public void ChangeSize(int nc, int mc)
    {
        Random rnd = new Random();
        int[,] B = new int[nc, mc]; //Массив который будет изменяться
                                    //если i или j > n,m соотвественно, то 
                                    //Поиск максимальных значений 
        for (int i = 0; i < nc; i++)
        {
            for (int j = 0; j < mc; j++)
            {
                if (i >= n | j >= m)
                {
                    B[i, j] = rnd.Next(l, r);
                }
                else
                {
                    B[i, j] = A[i, j];
                }
            }
        }
        //Удаление матрицы A
        n = nc;
        m = mc;
        A = B;
    }
    public void Print()
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($" {A[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public int this[int i, int j]
    {
        get
        {
            return A[i, j];
        }
        set
        {
            A[i, j] = value;
        }
    }
}