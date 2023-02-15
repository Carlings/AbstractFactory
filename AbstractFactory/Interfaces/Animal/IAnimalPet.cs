using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces.Animal
{
    internal interface IAnimalPet
    {
        string Type { get; set; }
        public double Weight { get; set; }
        public void Move();
        public void Sound();

    }
}
