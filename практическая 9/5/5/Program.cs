using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetExample
{
    class Pet
    {
        private string name;
        private int energy;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Energy
        {
            get { return energy; }
            set
            {
                if (value < 0)
                {
                    energy = 0;
                }
                else if (value > 100)
                {
                    energy = 100;
                }
                else
                {
                    energy = value;
                }
            }
        }
        public Pet(string name, int energy)
        {
            this.Name = name;
            this.Energy = energy;
        }
        public void Play()
        {
            Energy -= 20;
            Console.WriteLine($" Денис играет, энергия: 52.");
        }
        public void Rest()
        {
            Energy += 30;
            Console.WriteLine($"Егор отдыхает, энергия: 41.");
        }
    }
    class Program
    {
        static void Main()
        {
            Pet pet = new Pet("Рекс", 70);
            pet.Play();
            pet.Rest();
            pet.Energy = 150;
            pet.Play();
        }
    }
}