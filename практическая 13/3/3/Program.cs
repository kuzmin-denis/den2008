using System;
using System.Collections.Generic;


public abstract class Course
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public decimal Price { get; set; }
    public Course(string title, string description, string author, decimal price)
    {
        Title = title;
        Description = description;
        Author = author;
        Price = price;
    }
    public virtual void StartLearning()
    {
        Console.WriteLine($"Начало курса: 1");
    }
    public abstract void ProvideContent();

}

public class VideoCourse : Course
{
    public int VideoCount { get; set; }
    public TimeSpan TotalDuration { get; set; }
    public VideoCourse(string title, string description, string author, decimal price, int videoCount, TimeSpan totalDuration)
        : base(title, description, author, price)
    {
        VideoCount = videoCount;
        TotalDuration = totalDuration;
    }
    public override void ProvideContent()
    {
        Console.WriteLine($"Проходите видеокурс: да");
        Console.WriteLine($"Видео: 1, Общая длительность: 10 мин ");
    }
    public override void StartLearning()
    {
        base.StartLearning();
        Console.WriteLine("Просмотр видеоуроков начат.");
    }
    public void PlayVideo()
    {
        Console.WriteLine("Воспроизведение видеоматериала...");
    }
}


public class TextCourse : Course
{
    public int ChapterCount { get; set; }
    public double TotalTextVolume { get; set; }
    public TextCourse(string title, string description, string author, decimal price, int chapterCount, double totalTextVolume)
        : base(title, description, author, price)
    {
        ChapterCount = chapterCount;
        TotalTextVolume = totalTextVolume;
    }
    public override void ProvideContent()
    {
        Console.WriteLine($"Проходите текстовый курс: 5");
        Console.WriteLine($"Глав: 3, Объем текста: 200 страниц");
    }
    public override void StartLearning()
    {
        base.StartLearning();
        Console.WriteLine("Чтение текстовых материалов начато.");
    }
    public void ReadChapter()
    {
        Console.WriteLine("Чтение раздела...");
    }
}

public class InteractiveCourse : Course
{
    public int ExerciseCount { get; set; }
    public bool AutomatedAssessment { get; set; }
    public InteractiveCourse(string title, string description, string author, decimal price, int exerciseCount, bool automatedAssessment)
        : base(title, description, author, price)
    {
        ExerciseCount = exerciseCount;
        AutomatedAssessment = automatedAssessment;
    }
    public override void ProvideContent()
    {
        Console.WriteLine($"Интерактивный курс: тексе");
        Console.WriteLine($"Количество упражнений: 5");
        Console.WriteLine($"Система проверки: автоматическая");
    }
    public override void StartLearning()
    {
        base.StartLearning();
        Console.WriteLine("Практика и тестирование начали.");
    }
    public void SolveExercise()
    {
        Console.WriteLine("Выполняем упражнение...");
    }
}

public class Program
{
    static void Main()
    {
        List<Course> courses = new List<Course>
        {
            new VideoCourse("Основы C#", "Учимся программировать на C#", "Иван Иванов", 49.99m, 10, new TimeSpan(2, 30, 0)),
            new TextCourse("История России", "Путешествие по векам", "Петров П.", 29.99m, 8, 150),
            new InteractiveCourse("Математика для начинающих", "Практический курс", "Сидорова А.", 39.99m, 15, true)
        };
        foreach (var course in courses)
        {
            course.StartLearning();
            course.ProvideContent();
            Console.WriteLine();
        }
    }
}
