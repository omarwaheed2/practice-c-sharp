using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.BaseVehicle;

namespace OOP.BMW
{
    class BMW : BaseVehicle.BaseVehicle
    {
        internal short BMWseries { get; set; }
        internal string MAKE = "BMW";
        internal string transmissionConfig { get; set; }
        public BMW(int numTires, string color, short BMWseries, string transmissionConfig) : base(numTires, color)
        {
            this.BMWseries = BMWseries;
            this.make = MAKE;
            this.transmissionConfig = transmissionConfig;
        }

        public void transmission() {
            Console.WriteLine("Transmission is  " + this.transmissionConfig + " | " + "car : " + this.make);
        }

        public void series()
        {
            Console.WriteLine("Series is  " + this.BMWseries + " | " + "car : " + this.make);
        }

    }
}
