using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Counter
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Counter(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public static Counter operator +(Counter c, int increment)
    {
        c.Value += increment;
        return c;
    }

    public int this[string key]
    {
        get
        {
            if (key == "value")
                return Value;
            throw new ArgumentException("Недопустимый ключ");
        }
        set
        {
            if (key == "value")
                Value = value;
            else
                throw new ArgumentException("Недопустимый ключ");
        }
    }

    public override string ToString()
    {
        return $"{Name}: {Value}";
    }
}

class Program
{
    static void Main()
    {
        var c = new Counter("Счётчик", 10);
        c = c + 5;
        Console.WriteLine(c);

        c["value"] = 20; 
        Console.WriteLine(c["value"]); 
    }
}
