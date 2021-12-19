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
            cat.Say();            
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }     

        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine($"Название животного: {Name}, его звук: {0}");
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

}
