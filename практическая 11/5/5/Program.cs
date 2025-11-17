using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    private decimal price;
    private decimal discount;

    public string Name { get; set; } = "Без названия";

    public decimal Price
    {
        get => price;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Цена не может быть отрицательной!");
                price = 0;
            }
            else
            {
                price = value;
            }
        }
    }

    public decimal Discount
    {
        get => discount;
        set
        {
            if (value < 0)
            {
                discount = 0;
            }
            else if (value > 100)
            {
                discount = 100;
            }
            else
            {
                discount = value;
            }
        }
    }

    public decimal FinalPrice => Price * (1 - Discount / 100);

    public Product(decimal price, decimal discount)
    {
        Price = price;
        { }
        Discount = discount;
    }
        

    public void Show()
    {
        Console.WriteLine($"п: 100 5%)");
    }
}

class Program
{
    static void Main()
    {

        Product product = new Product(1000, 20);
        product.Name = "Ноутбук"; 
        product.Show();


        product.Discount = 10;
        product.Show();

        product.Price = -500;
        product.Show();
    }
}
