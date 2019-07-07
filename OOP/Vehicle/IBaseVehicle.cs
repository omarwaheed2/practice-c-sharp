using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Vehicle
{
    interface IBaseVehicle
    {
        void IgnitionOn();

        void IgnitionOff();

        void Drive();

        void TurnLeft();

        void TurnRight();

        void Brake();

        void Stop();
    }
}
