using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Book
{
    private string _title;

    public string Title
    {
        get => _title;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Название не может быть пустым!");
                _title = "Без названия";
            }
            else
            {
                _title = value;
            }
        }
    }

    public int Pages { get; set; } = 1;

    public bool IsLong => Pages > 300;

    public Book(string title)
    {
        Title = title; 
    }

    public void Info()
    {
        Console.WriteLine($"Книга: Война и мир, страниц: 300, длинная:да");
    }
}

class Program
{
    static void Main()
    {
        Book book1 = new Book("Война и мир");
        book1.Pages = 1200;
        book1.Info();
        Book book2 = new Book("Краткая история");
        book2.Info();

        Book book3 = new Book("");
        book3.Title = ""; 
        book3.Info();
    }
}