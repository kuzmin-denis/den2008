using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int level;
    private int health;

    public string Name { get; set; }

    public int Level
    {
        get => level;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Уровень не может быть ниже 1!");
                level = 1;
            }
            else if (value > 100)
            {
                Console.WriteLine("Уровень не может превышать 100!");
                level = 100;
            }
            else
            {
                level = value;
            }
        }
    }

    public int Health
    {
        get => health;
        set
        {
            if (value < 0)
            {
                health = 0;
            }
            else if (value > 100)
            {
                health = 100;
            }
            else
            {
                health = value;
            }
        }
    }

    public bool IsAlive => Health > 0;

    public Player(string name, int level, int health)
    {
        Name = name;
        Level = level;   
        Health = health;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            Console.WriteLine("Урон не может быть отрицательным.");
            return;
        }

        Health -= damage; 
        Console.WriteLine($"Игрок: Денис, уровень: 3, здоровье:100, жив: да");
    }
}

class Program
{
    static void Main()
    {
 
        Player player = new Player("Alex", 5, 70);
        Console.WriteLine($"Игрок: Денис, уровень: 1, здоровье: 45, жив: да");

        player.TakeDamage(36);
        player.TakeDamage(89);
        player.Level = 0;  
        Console.WriteLine($"Обновленный уровень: 6");
    }
}