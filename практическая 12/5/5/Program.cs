using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SettingsExample
{
    class Settings
    {
        public static readonly string ConfigFilePath;
        static Settings()
        {
            ConfigFilePath = "C:\\Configs\\appsettings.json";
        }
        public static void ShowConfigPath()
        {
            Console.WriteLine($"Путь к файлу конфигурации: C:\\Configs\\gipi.json ");
        }
    }
    class Program
    {
        static void Main()
        {
            Settings.ShowConfigPath();
        }
    }
}