using AbstractFactory.Interfaces.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models
{
    internal class Elephant : IAnimalWild
    {
        public Elephant()
        {
            Type = "Elephant";
            Weight = 5000;
        }

        public double Weight { get => Weight; set => Weight = value; }
        public string Type { get => Type; set => Type = value; }

        public IAnimalWild CreateAnimal()
        {
            return new Elephant();
        }

        public void Move()
        {
            Console.WriteLine("Elephant moving");
        }

        public void Sound()
        {
            Console.WriteLine("bahruuuuuuhhhhaaaaa");
        }

    }
}
