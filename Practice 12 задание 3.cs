using System;

class ObjectCounter
{
    private static int count = 0;

    public ObjectCounter()
    {
        count++;
    }

    public static void ShowCount()
    {
        Console.WriteLine($"Создано объектов: {count}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ObjectCounter a = new ObjectCounter();
        ObjectCounter b = new ObjectCounter();
        ObjectCounter c = new ObjectCounter();

        ObjectCounter.ShowCount();

        Console.ReadLine();
    }
}