using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeviceLaptopExample
{
    class Device
    {
        protected string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public Device(string brand)
        {
            this.Brand = brand;
        }
        public void PowerOn()
        {
            Console.WriteLine($"{Brand} включён.");
        }
    }
    class Laptop : Device
    {
        private int ram;
        private int battery;
        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("ОЗУ должно быть от 1 до 64!");
                    ram = 1;
                }
                else if (value > 64)
                {
                    ram = 64;
                }
                else
                {
                    ram = value;
                }
            }
        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0)
                {
                    battery = 0;
                }
                else if (value > 100)
                {
                    battery = 100;
                }
                else
                {
                    battery = value;
                }
            }
        }
        public Laptop(string brand, int ram, int battery) : base(brand)
        {
            this.Ram = ram;
            this.Battery = battery;
        }
        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {Ram} ГБ, заряд: {Battery}%.");
        }
    }
    class Program
    {
        static void Main()
        {
            Laptop myLaptop = new Laptop("Dell", 16, 85);
            myLaptop.PowerOn();
            myLaptop.Work();
            myLaptop.Ram = 0;
            myLaptop.Work();
        }
    }
}