using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public bool TakesGas { get; set; }
        public bool IsConvertible { get; set; }
        public int NumberOfSeats { get; set; }
        public void HonkNoise();       
                
    }
}
