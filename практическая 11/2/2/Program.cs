using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Phone
{
    private int battery;

    public int BatteryLevel
    {
        get { return battery; }
        set
        {
            if (value > 100)
            {
                Console.WriteLine("Заряд не может превышать 100!");
                battery = 100;
            }
            else if (value < 0)
            {
                battery = 0;
            }
            else
            {
                battery = value;
            }
        }
    }

    public string Brand { get; set; }

    public Phone(string brand, int initialCharge)
    {
        Brand = brand;
        BatteryLevel = initialCharge;
    }

    public void Use()
    {
        int newCharge = BatteryLevel - 10;
        BatteryLevel = newCharge;
        Console.WriteLine($"apple: заряд 68%.");
    }
}

class Program
{
    static void Main()
    {

        Phone myPhone = new Phone("Samsung", 70);

        myPhone.Use();
        myPhone.Use();
        myPhone.Use();
        myPhone.BatteryLevel = 150; 
    }
}