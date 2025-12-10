using System;

public struct Color
{
    public int R { get; set; }
    public int G { get; set; }
    public int B { get; set; }
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }
}
class Program
{
    static void Main()
    {
        var c1 = new Color(255, 128, 0);
        var c2 = c1;
        c2.R = 100;
        Console.WriteLine(c1);
        Console.WriteLine(c2);
    }
}