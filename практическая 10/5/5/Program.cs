using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnimalCatExample
{
    class Animal
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            this.Name = name;
        }
        public virtual void Speak()
        {
            Console.WriteLine($"{Name} издаёт звук.");
        }
    }
    class Cat : Animal
    {
        private int lives;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value < 1)
                {
                    lives = 1;
                }
                else if (value > 9)
                {
                    lives = 9;
                }
                else
                {
                    lives = value;
                }
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            this.Lives = lives;
        }
        public Cat(string name) : this(name, 9)
        {
        }
        public void Meow()
        {
            if (Lives > 1)
            {
                Lives--;
            }
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {Lives}.");
        }
        public override void Speak()
        {
            Console.WriteLine($"{Name} издаёт звук.");
        }
    }
    class Program
    {
        static void Main()
        {
            Cat cat1 = new Cat("Мурзик", 8);
            Cat cat2 = new Cat("Барсик");
            cat1.Speak();
            cat1.Meow();
            cat1.Meow();
            cat2.Speak();
            cat2.Meow();
            cat2.Meow();
        }
    }
}