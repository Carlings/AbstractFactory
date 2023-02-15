using AbstractFactory.Interfaces;
using AbstractFactory.Interfaces.Animal;

namespace AbstractFactory.Models
{
    internal class Cat : IAnimalPet
    {
        public Cat()
        {
            Type = "Cat";
            Weight = 2.5;
        }

        public double Weight { get; set; }
        public string Type { get; set; }

        public IAnimalPet CreateAnimal()
        {
            return new Cat();
        }

        public void Move()
        {
            Console.WriteLine("Cat moves");
        }

        public void Sound()
        {
            Console.WriteLine("Meow.. meow.. dai pokushat` pls");
        }
    }
}
