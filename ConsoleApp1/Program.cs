// Task 1
using System;

public static class Utilities
{
    public static void Swap<T>(ref T x, ref T y) where T : struct
    {
        T temp = x;
        x = y;
        y = temp;
    }
}

class Program
{
    static void Main()
    {
        int a = 1, b = 2;
        Utilities.Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");

        double c = 3.14, d = 2.718;
        Utilities.Swap(ref c, ref d);
        Console.WriteLine($"c: {c}, d: {d}");

        bool e = true, f = false;
        Utilities.Swap(ref e, ref f);
        Console.WriteLine($"e: {e}, f: {f}");
    }
}
