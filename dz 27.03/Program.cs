using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz27._03
{
    abstract class Person
    {
        public string name;
        public int attack;
        public int speed;
        public int health;
        public int protection;

        abstract public void Print();
    }

    class Human : Person
    {
        public override void Print()
        {
            name = "Человек";
            attack = 5;
            speed = 15;
            health = 100;
            protection = 0;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }

    class Elf : Person
    {
        public override void Print()
        {
            name = "Носорог";
            attack = 35;
            speed = 40;
            health = 100;
            protection = 100;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }


    class Decorator : Person
    {
        protected Person person;

        public Decorator(Person person)
        {
            this.person = person;
        }
        public void SetPerson(Person person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }

    class HumanWarrior : Decorator
    {
        public HumanWarrior(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack += 20}");
            Console.WriteLine($"Speed: {speed += 10}");
            Console.WriteLine($"Health: {health += 50}");
            Console.WriteLine($"Protection: {protection += 20}");
        }
    }
    class Swordsman : Decorator
    {
        public Swordsman(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack += 40}");
            Console.WriteLine($"Speed: {speed -= 10}");
            Console.WriteLine($"Health: {health += 50}");
            Console.WriteLine($"Protection: {protection += 40}");
        }
    }
    class Archer : Decorator
    {
        public Archer(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class Rider : Decorator
    {
        public Rider(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class ElfWarrior : Decorator
    {
        public ElfWarrior(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class ElfMage : Decorator
    {
        public ElfMage(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class Crossbowelf : Decorator
    {
        public Crossbowelf(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class EvilMage : Decorator
    {
        public EvilMage(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }
    class GoodMage : Decorator
    {
        public GoodMage(Person person) : base(person)
        {
            this.person = person;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Attack: {attack}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Protection: {protection}");
        }
    }


    class Client
    {
        public void SetPerson(Person person)
        {
            person.Print();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            var a = new Human();
            client.SetPerson(a);

            Console.WriteLine();

            HumanWarrior hw = new HumanWarrior(a);
            client.SetPerson(hw);

            Console.WriteLine();

            Swordsman sw = new Swordsman(a);
            client.SetPerson(sw);

        }
    }
}