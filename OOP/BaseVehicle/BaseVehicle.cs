using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BaseVehicle
{


    class BaseVehicle : IBaseVehicle
    {
        internal string class_name = "BASE_VEHICLE :";
        internal int numTires { get; }
        internal string color { get; set; }
        internal string make { get; set; }
        internal readonly string MAKE = "BaseCar";

        public BaseVehicle(int numTires, string color) {
            this.numTires = numTires;
            this.color = color;
            this.make = MAKE;
        }

        public void Brake()
        {
            Console.WriteLine("Applying Brake | car : " + make);
        }

        public void Drive()
        {
            Console.WriteLine("Starting to Drive | car : " + make);
        }

        public void IgnitionOff()
        {
            Console.WriteLine("Turning off Ignition | car : " + make);
        }

        public void IgnitionOn()
        {
            Console.WriteLine("Turning on Ignition | car : " + make);
        }

        public void Stop()
        {
            Console.WriteLine("Bringing car to a stop | car : " + make);
        }

        public void TurnLeft()
        {
            Console.WriteLine("Turning Left | car : " + make);
        }

        public void TurnRight()
        {
            Console.WriteLine("Turning on Right | car : " + make);
        }
    }
}
