using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.ConcreteFactories;
using AbstractFactory.Models;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory animalFactory;
            animalFactory = new PetFactory();
            animalFactory.CreateCat().Sound();
        }
    }
}