using System; // подключение к библиотеке
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahahahah // пространство имен
{
    internal class Program // тело программы
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            string num1Input = Console.ReadLine(); 
            if (!double.TryParse(num1Input, out double num1))
            {
                Console.WriteLine("Неверный ввод");
                return;
            }
            Console.WriteLine("Введите второе число:");
            string num2Input = Console.ReadLine();
            if (!double.TryParse (num2Input, out double num2))
            {
                Console.WriteLine("Невереный ввод"); 
                return;
            }

            double sum = num1 + num2;
            double dif = num1 - num2; 
            double prod = num1 * num2;
            double div = num1 / num2;
            if (num2 == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return;
            }
            else
            {
                Console.WriteLine($"Сумма = {sum:F2}");
                Console.WriteLine($"Разность = {dif:F2}");
                Console.WriteLine($"Произведенние = {prod:F2}");
                Console.WriteLine($"Деление = {div:F2}");
            }



        }
    }
}
