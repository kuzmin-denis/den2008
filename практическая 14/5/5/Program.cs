using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    public class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    public class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    public class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
    class Program
    {
        static void Main()
        {
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team)
            {
                p.Attack();
            }
        }
    }
}