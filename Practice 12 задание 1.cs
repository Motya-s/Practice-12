using System;

class Calculator
{
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль!");
            return double.NaN;
        }
        return a / b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Сложение: {Calculator.Add(2, 3)}");
        Console.WriteLine($"Вычитание: {Calculator.Subtract(2, 3)}");
        Console.WriteLine($"Умножение: {Calculator.Multiply(1, 3)}");
        Console.WriteLine($"Деление: {Calculator.Divide(3, 0)}");

        Console.ReadLine();
    }
}