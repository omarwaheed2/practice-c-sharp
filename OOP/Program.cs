using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Vehicle;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running OOP");

            Console.WriteLine("Car # 1");
            BaseVehicle baseVehicle = new BaseVehicle(4, "black", "BaseCar");
            baseVehicle.IgnitionOn();
            baseVehicle.Drive();
            baseVehicle.TurnLeft();
            baseVehicle.TurnRight();
            baseVehicle.Brake();
            baseVehicle.Stop();

            Console.ReadLine();
        }
    }
}
