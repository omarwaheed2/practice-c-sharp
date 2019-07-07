using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.BaseVehicle;
using OOP.BMW;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running OOP");

            Console.WriteLine("Car # 1 of baseVehicle class");
            BaseVehicle.BaseVehicle baseVehicle = new BaseVehicle.BaseVehicle(4, "black");
            baseVehicle.IgnitionOn();
            baseVehicle.Drive();
            baseVehicle.TurnLeft();
            baseVehicle.TurnRight();
            baseVehicle.Brake();
            baseVehicle.Stop();
            Console.ReadLine();

            Console.WriteLine("Car # 2 of BMW class 5 series");
            BMW.BMW bmw5Series = new BMW.BMW(4, "Navy", 5, "Manual");
            bmw5Series.transmission();
            bmw5Series.series();
            bmw5Series.IgnitionOn();
            bmw5Series.Drive();
            bmw5Series.TurnLeft();
            bmw5Series.TurnRight();
            bmw5Series.Brake();
            bmw5Series.Stop();
            Console.ReadLine();

            Console.WriteLine("Car # 3 of BMW class 7 series");
            BMW.BMW bmw7Series = new BMW.BMW(4, "Red", 7, "Autmoatic");
            bmw7Series.transmission();
            bmw7Series.series();
            bmw7Series.IgnitionOn();
            bmw7Series.Drive();
            bmw7Series.TurnLeft();
            bmw7Series.TurnRight();
            bmw7Series.Brake();
            bmw7Series.Stop();
            Console.ReadLine();


        }
    }
}
