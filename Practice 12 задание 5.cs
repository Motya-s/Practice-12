using System;

class Settings
{
    private static readonly string configPath;

    static Settings()
    {
        configPath = "C:\\ProgramData\\App\\config.txt";
    }

    public static void ShowPath()
    {
        Console.WriteLine($"Путь к файлу конфигурации: {configPath}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Settings.ShowPath();
        Console.ReadLine();
    }
}