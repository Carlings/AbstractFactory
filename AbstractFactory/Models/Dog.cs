using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    internal class Dog : IAnimalPet
    {
        public Dog()
        {
            Type = "Dog";
            Weight = 10;
        }

        public double Weight { get; set; }
        public string Type { get; set; }

        public IAnimalPet CreateAnimal()
        {
            return new Dog();
        }

        public void Move()
        {
            Console.WriteLine("Dog moving");
        }

        public void Sound()
        {
            Console.WriteLine("Woof.. woof..");
        }
    }
}
