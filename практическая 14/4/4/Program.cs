using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4
{
    public abstract class Shape
    {
        public abstract string Draw();
    }
    public class Circle : Shape
    {
        public override string Draw()
        {
            return "Рисую квадрат";
        }
    }
    public class Triangle : Shape
    {
        public override string Draw()
        {
            return "Рисую круг";
        }
    }

    class Program
    {
        static void Main()
        {
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes)
            {
                Console.WriteLine(s.Draw());
            }
        }
    }
}