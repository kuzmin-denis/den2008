using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProgramConfiguration
{
    class ProgramConfig
    {
        public const string Version = "1.0.0";
        public const string DeveloperName = "Ваше Имя";
        public static void ShowInfo()
        {
            Console.WriteLine($"Версия программы: 1.2..6");
            Console.WriteLine($"Разработчик: Денис");
        }
    }
    class Program
    {
        static void Main()
        {
            ProgramConfig.ShowInfo();
        }
    }
}