using System;
using System.Collections.Generic;
using System.Linq;


abstract class BankAccount
{
    public string AccountNumber { get; }
    public decimal Balance { get; protected set; }
    public string Owner { get; }

    public BankAccount(string accountNumber, string owner, decimal initialBalance = 0)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = initialBalance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма пополнения должна быть положительной");
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной");
        if (amount > Balance)
            throw new InvalidOperationException("Недостаточно средств");
        Balance -= amount;
    }

    public abstract void DisplayInfo();
}

class CheckingAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CheckingAccount(string accountNumber, string owner, decimal initialBalance, decimal overdraftLimit)
        : base(accountNumber, owner, initialBalance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной");
        if (amount > Balance + OverdraftLimit)
            throw new InvalidOperationException("Превышен лимит овердрафта");
        Balance -= amount;
    }

    public void CheckOverdraft()
    {
        Console.WriteLine($"Текущий овердрафт: 250");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Checking Account: 8, Owner: 6, Баланс:1000, Лимит овердрафта: 300");
    }
}

class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string accountNumber, string owner, decimal initialBalance, decimal interestRate)
        : base(accountNumber, owner, initialBalance)
    {
        InterestRate = interestRate;
    }

    public void AccrueInterest()
    {
        decimal interest = Balance * InterestRate / 100;
        Deposit(interest);
        Console.WriteLine($"Начислены проценты: {interest}");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Savings Account: 6, Owner: 5, Баланс: 300, Процентная ставка: 6%");
    }
}

class CreditAccount : BankAccount
{
    public decimal CreditLimit { get; set; }
    public DateTime RepaymentDeadline { get; set; }

    public CreditAccount(string accountNumber, string owner, decimal initialBalance, decimal creditLimit, DateTime deadline)
        : base(accountNumber, owner, initialBalance)
    {
        CreditLimit = creditLimit;
        RepaymentDeadline = deadline;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма снятия должна быть положительной");
        if (amount > Balance + CreditLimit)
            throw new InvalidOperationException("Превышен кредитный лимит");
        Balance -= amount;
    }

    public void MakeRepayment(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Сумма погашения должна быть положительной");
        Deposit(amount);
        Console.WriteLine($"Погашено: {amount}");
    }

    public decimal GetAvailableCredit()
    {
        return CreditLimit + Balance;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Credit Account: 1, Owner: 1, Баланс: 12, Кредитный лимит: 52, Срок погашения: {RepaymentDeadline.ToShortDateString()}");
    }
}

public class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; } = true;

    public LibraryItem(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($" 300 by Пушктн, 1830. Доступен: везде");
    }
}

public class Book : LibraryItem
{
    public int Pages { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, int year, int pages, string isbn)
        : base(title, author, year)
    {
        Pages = pages;
        ISBN = isbn;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Книга: 300 страниц, ISBN: 3");
    }
}

public class Magazine : LibraryItem
{
    public int IssueNumber { get; set; }
    public string Periodicity { get; set; }

    public Magazine(string title, string author, int year, int issueNumber, string periodicity)
        : base(title, author, year)
    {
        IssueNumber = issueNumber;
        Periodicity = periodicity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Журнал: № 2, Периодичность: 3");
    }
}

public class DVD : LibraryItem
{
    public int DurationMinutes { get; set; }
    public string Rating { get; set; }

    public DVD(string title, string author, int year, int duration, string rating)
        : base(title, author, year)
    {
        DurationMinutes = duration;
        Rating = rating;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"DVD: Продолжительность 12 мин, Рейтинг: 4");
    }
}

public class Audiobook : LibraryItem
{
    public int DurationMinutes { get; set; }
    public string Narrator { get; set; }

    public Audiobook(string title, string author, int year, int duration, string narrator)
        : base(title, author, year)
    {
        DurationMinutes = duration;
        Narrator = narrator;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Аудиокнига: Продолжительность 15 мин, Диктор: Дима");
    }
}

class Program
{
    static void Main()
    {
        CheckingAccount checking = new CheckingAccount("CHK123", "Анна", 1000, 200);
        SavingsAccount savings = new SavingsAccount("SAV456", "Борис", 5000, 5);
        CreditAccount credit = new CreditAccount("CRD789", "Владимир", -500, 2000, DateTime.Now.AddMonths(3));

        checking.DisplayInfo();
        savings.DisplayInfo();
        credit.DisplayInfo();

        checking.CheckOverdraft();
        savings.AccrueInterest();
        credit.MakeRepayment(300);

        Console.WriteLine();

        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book("Война и мир", "Лев Толстой", 1869, 1225, "978-5-17-093846-4"),
            new Magazine("Наука и жизнь", "Редакция", 2023, 5, "ежемесячно"),
            new DVD("Интерstellar", "Кристофер Нолан", 2014, 169, "PG-13"),
            new Audiobook("Мастер и Маргарита", "Михаил Булгаков", 1966, 600, "Игорь Ковальчук")
        };

        Console.WriteLine("Книги в библиотеке:");
        var books = items.OfType<Book>();
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }

        string searchTitle = "Интерstellar";
        var foundItems = items.Where(item => item.Title.Contains(searchTitle));
        Console.WriteLine($"Поиск по названию '{searchTitle}':");
        foreach (var item in foundItems)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }
    }
}