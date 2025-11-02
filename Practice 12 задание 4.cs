using System;

class Book
{
    private readonly string ISBN;
    private string title;
    private string author;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    public Book(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author}, ISBN: {ISBN}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("978-5-389-07446-0", "Преступление и наказание", "Ф. Достоевский");
        book.ShowInfo();

        Console.ReadLine();
    }
}