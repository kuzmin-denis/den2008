using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorExample
{
    static class Calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                return double.NaN;
            }
            return a / b;
        }
    }
    class Program
    {
        static void Main()
        {
            double a = 10;
            double b = 5;
            Console.WriteLine($"Сложение: {Calculator.Add(a, b)}");
            Console.WriteLine($"Вычитание: {Calculator.Subtract(a, b)}");
            Console.WriteLine($"Умножение: {Calculator.Multiply(a, b)}");
            Console.WriteLine($"Деление: {Calculator.Divide(a, b)}");
            Console.WriteLine($"Деление на ноль: {Calculator.Divide(a, 0)}");
        }
    }
}
