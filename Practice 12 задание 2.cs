using System;

class ProgramConfig
{
    private const string DeveloperName = "Матвей Иванов";
    private const string Version = "3.2.1";

    public static void ShowInfo()
    {
        Console.WriteLine($"Разработчик: {DeveloperName}");
        Console.WriteLine($"Версия программы: {Version}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProgramConfig.ShowInfo();
        Console.ReadLine();
    }
}