using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace PersonExample
{
    class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else if (value > 120)
                {
                    age = 120;
                }
                else
                {
                    age = value;
                }
            }
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void SayHello()
        {
            Console.WriteLine($"Привет, я Денис, мне 17 лет!");
        }
    }

    class Program
    {
        static void Main()
        {

            Person person = new Person("Маша", 25);
            person.SayHello();
            person.Age = 150;
            person.SayHello();


            person.Age = -5;
            person.SayHello();
        }
    }
}


