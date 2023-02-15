using AbstractFactory.Interfaces.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    internal class Lion : IAnimalWild
    {
        public Lion()
        {
            Type = "Lion";
            Weight = 5000;
        }

        public double Weight { get => Weight; set => Weight = value; }
        public string Type { get => Type; set => Type = value; }

        public IAnimalWild CreateAnimal()
        {
            return new Lion();
        }

        public void Move()
        {
            Console.WriteLine("Lion moving");
        }

        public void Sound()
        {
            Console.WriteLine("grraaaauuuu!");
        }
    }
}
