using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneExample
{
    class Phone
    {
        private string brand;
        private int batteryLevel;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int BatteryLevel
        {
            get { return batteryLevel; }
            set
            {
                if (value < 0)
                {
                    batteryLevel = 0;
                }
                else if (value > 100)
                {
                    batteryLevel = 100;
                }
                else
                {
                    batteryLevel = value;
                }
            }
        }
        public Phone(string brand, int batteryLevel)
        {
            this.Brand = brand;
            this.BatteryLevel = batteryLevel;
        }
        public void UsePhone()
        {
            Console.WriteLine($"Телефон aplle, заряд: 49%.");
        }
    }
    class Program
    {
        static void Main()
        {
            Phone phone = new Phone("Samsung", 80);
            phone.UsePhone();
            phone.UsePhone();
            phone.BatteryLevel = -10;
            Console.WriteLine("Заряд должен быть от 0 до 100!");
            phone.UsePhone();
        }
    }
}