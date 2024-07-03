using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_7_2._2
{
    internal class Program
    {
        internal interface ISound
        {
            void MakeSound();
        }

        internal abstract class Animal
        {
            public Animal(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
            public abstract void Eat();
            public void Sleep()
            {
                Console.WriteLine($"the animal's name{Name} is sleeping");
            }
        }
       

        internal class Cat : Animal, ISound
        {
            public Cat(string name) : base(name) { }

            public override void Eat() { Console.WriteLine($"{Name}is eating whatever it want"); }
            public void MakeSound() { Console.WriteLine($"{Name}blablabla"); }
        }

        internal class Dog : Animal, ISound
        {
            public Dog(string name) : base(name) { }
            public override void Eat() { Console.WriteLine($"{Name} is eating whatever it want"); }
            public void MakeSound() { Console.WriteLine($"{Name}"); }
        }
        static void Main(string[] args)
        {

        }
    }
}
