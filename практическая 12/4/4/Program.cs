using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookExample
{
    class Book
    {
        private readonly string isbn;
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string isbn, string title, string author)
        {
            this.isbn = isbn;
            this.Title = title;
            this.Author = author;
        }
        public string ISBN
        {
            get { return isbn; }
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ISBN: 456.46-64");
            Console.WriteLine($"Название: Демоны");
            Console.WriteLine($"Автор: Неизвестен ");
        }
    }
    class Program
    {
        static void Main()
        {
            Book myBook = new Book("978-3-16-148410-0", "Преступление и наказание", "Ф. М. Достоевский");
            myBook.PrintInfo();
        }
    }
}