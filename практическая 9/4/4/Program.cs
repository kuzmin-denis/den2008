using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleExample
{
    class Circle
    {
        private double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                {
                    radius = value;
                }
                else
                {
                    radius = 1;
                    Console.WriteLine("Радиус должен быть больше 0!");
                }
            }
        }
        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.Radius = radius;
            }
            else
            {
                this.Radius = 1;
                Console.WriteLine("Радиус должен быть больше 0!");
            }
        }
        public void GetArea()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Площадь круга: {area}.");
        }
    }
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            circle.GetArea();
            circle.Radius = -2;
            circle.GetArea();
        }
    }
}