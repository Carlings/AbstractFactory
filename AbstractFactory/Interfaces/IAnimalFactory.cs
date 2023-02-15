using AbstractFactory.Interfaces.Animal;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    internal interface IAnimalFactory
    {
        public IAnimalPet CreateCat();
        public IAnimalPet CreateDog();
        public IAnimalWild CreateElephant();
        public IAnimalWild CreateLion();
    }
}
