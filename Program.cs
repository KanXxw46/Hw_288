using System;

namespace Hw288
{
    class Program
    {
        static void Main(string[] args)
        {
            CarMaking carMaking = new HeavyCar3();
            carMaking = new LikerCoffee(carMaking);
            Console.WriteLine(carMaking.Name + " " + carMaking.getCost());
        }
    }
}
