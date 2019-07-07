using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicle
{


    class BaseVehicle : IBaseVehicle
    {
        internal string CLASS_NAME = "BASE_VEHICLE :";
        internal int numTires { get; }
        internal string color { get; set; }
        internal string make { get; set; }

        public BaseVehicle(int numTires, string color, string make) {
            this.numTires = numTires;
            this.color = color;
            this.make = make;
        }

        public void Brake()
        {
            Console.WriteLine(CLASS_NAME + "Applying Brake | car : " + make);
        }

        public void Drive()
        {
            Console.WriteLine(CLASS_NAME + "Starting to Drive | car : " + make);
        }

        public void IgnitionOff()
        {
            Console.WriteLine(CLASS_NAME + "Turning off Ignition | car : " + make);
        }

        public void IgnitionOn()
        {
            Console.WriteLine(CLASS_NAME + "Turning on Ignition | car : " + make);
        }

        public void Stop()
        {
            Console.WriteLine(CLASS_NAME + "Bringing car to a stop | car : " + make);
        }

        public void TurnLeft()
        {
            Console.WriteLine(CLASS_NAME + "Turning Left | car : " + make);
        }

        public void TurnRight()
        {
            Console.WriteLine(CLASS_NAME + "Turning on Right | car : " + make);
        }
    }
}
