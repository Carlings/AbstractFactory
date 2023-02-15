using AbstractFactory.Interfaces.Animal;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces.ConcreteFactories
{
    internal class PetFactory : IAnimalFactory
    {
        public IAnimalPet CreateCat()
        {
            return new Cat();
        }

        public IAnimalPet CreateDog()
        {
            return new Dog();
        }

        public IAnimalWild CreateElephant()
        {
            return null;
        }

        public IAnimalWild CreateLion()
        {
            return null;
        }
    }
}
