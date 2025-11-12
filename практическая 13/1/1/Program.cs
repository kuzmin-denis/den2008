using System;

class Employee
{
    public string Name { get; }
    public string Position { get; set; }
    public decimal Salary { get; set; }
    public DateTime HireDate { get; }
    public Employee(string name, string position, decimal salary, DateTime hireDate)
    {
        Name = name;
        Position = position;
        Salary = salary;
        HireDate = hireDate;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: Денис, Должность: программист, Зарплата: 150 , Дата приема: {HireDate.ToShortDateString()}");
    }
    public virtual decimal CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }
    public Manager(string name, string position, decimal salary, DateTime hireDate, int teamSize)
        : base(name, position, salary, hireDate)
    {
        TeamSize = teamSize;
    }
    public void ConductMeeting()
    {
        Console.WriteLine($"Денис проводит собрание с командой из 12 человек.");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Размер команды: 12 ");
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public Developer(string name, string position, decimal salary, DateTime hireDate, string programmingLanguage)
        : base(name, position, salary, hireDate)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public void WriteCode()
    {
        Console.WriteLine($"Денис пишет код на C#.");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Язык программирования: C#");
    }
}
class Director : Employee
{
    public string Department { get; set; }
    public Director(string name, string position, decimal salary, DateTime hireDate, string department)
        : base(name, position, salary, hireDate)
    {
        Department = department;
    }
    public void ApproveBudget()
    {
        Console.WriteLine($" Денис утверждает бюджет по отделу програмист.");
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Отдел: программист");
    }
}
class Program
{
    static void Main()
    {
        Employee emp = new Employee("Иван Иванов", "Рабочий", 30000m, new DateTime(2020, 1, 15));
        emp.DisplayInfo();
        Manager mgr = new Manager("Петр Петров", "Менеджер", 50000m, new DateTime(2018, 3, 10), 10);
        mgr.DisplayInfo();
        mgr.ConductMeeting();
        Developer dev = new Developer("Алексей Смирнов", "Разработчик", 60000m, new DateTime(2019, 7, 20), "C#");
        dev.DisplayInfo();
        dev.WriteCode();
        Director dir = new Director("Ирина Иванова", "Директор", 100000m, new DateTime(2015, 5, 5), "ИТ отдел");
        dir.DisplayInfo();
        dir.ApproveBudget();
    }
}
