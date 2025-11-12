using System;

public abstract class Animal
{
    public string Species { get; set; }
    public int Age { get; set; }
    public string Habitat { get; set; }
    public string Diet { get; set; }
    public Animal(string species, int age, string habitat, string diet)
    {
        Species = species;
        Age = age;
        Habitat = habitat;
        Diet = diet;
    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Вид: обычный, Возраст: 17, Среда обитания: Владимир, Рацион: Владимирский");
    }
}
public class Mammal : Animal
{
    public string FurType { get; set; }
    public int PregnancyDuration { get; set; }
    public Mammal(string species, int age, string habitat, string diet, string furType, int pregnancyDuration)
        : base(species, age, habitat, diet)
    {
        FurType = furType;
        PregnancyDuration = pregnancyDuration;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип меха: норка, Продолжительность беременности: 200 дней");
    }
}

public class Bird : Animal
{
    public double Wingspan { get; set; }
    public string NestingType { get; set; }
    public Bird(string species, int age, string habitat, string diet, double wingspan, string nestingType)
        : base(species, age, habitat, diet)
    {
        Wingspan = wingspan;
        NestingType = nestingType;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Размах крыльев: 1 м, Тип гнездования: деревянное");
    }
}


public class Reptile : Animal
{
    public string SkinType { get; set; }
    public double EnvironmentTemperature { get; set; }
    public Reptile(string species, int age, string habitat, string diet, string skinType, double environmentTemperature)
        : base(species, age, habitat, diet)
    {
        SkinType = skinType;
        EnvironmentTemperature = environmentTemperature;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип кожи: мулат, Температура среды: 36 °C");
    }
}

public class Fish : Animal
{
    public string ScaleType { get; set; }
    public double DepthHabitat { get; set; }
    public Fish(string species, int age, string habitat, string diet, string scaleType, double depthHabitat)
        : base(species, age, habitat, diet)
    {
        ScaleType = scaleType;
        DepthHabitat = depthHabitat;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип чешуи: серая, Глубина обитания: 20 м");
    }
}

public class Program
{
    static void Main()
    {
        Mammal lion = new Mammal("Лев", 5, "Саванна", "Мясо", "Короткий мех", 110);
        Bird eagle = new Bird("Орёл", 3, "Лес", "Мясо", 2.3, "Гнездование на деревьях");
        Reptile snake = new Reptile("Змея", 2, "Пустыня", "Плоть и яйца", "Чешуя", 30);
        Fish salmon = new Fish("Лосось", 4, "Река", "Плоть", "Крупная", 50);
        Animal[] animals = { lion, eagle, snake, salmon };
        foreach (var animal in animals)
        {
            animal.DisplayInfo();
            Console.WriteLine();
        }
    }
}