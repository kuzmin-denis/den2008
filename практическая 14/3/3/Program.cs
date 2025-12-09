using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    public class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    public class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пасту!");
        }
    }
    public class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пасту!");
        }
    }
    class Program
    {
        static void Main()
        {
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch)
            {
                f.Eat();
            }
        }
    }
}