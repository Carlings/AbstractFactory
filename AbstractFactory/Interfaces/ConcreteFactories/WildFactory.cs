using AbstractFactory.Interfaces.Animal;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces.ConcreteFactories
{
    internal class WildFactory : IAnimalFactory
    {
        public IAnimalPet CreateCat() => null;

        public IAnimalPet CreateDog() => null;

        public IAnimalWild CreateElephant() => new Elephant();

        public IAnimalWild CreateLion() => new Lion();
    }
}
