using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мурка");
            cat.ShowInfo();
            Dog dog = new Dog("Бобик");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }     

        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine($"Название животного: {Name}, его звук: ");
            Say();
        }
        
    }
    class Cat : Animal
    {
        string name;

        public Cat(string name)
        {
            Name = name;            
        }
        
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Dog : Animal
    {
        string name;

        public Dog(string name)
        {
            Name = name;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

}
