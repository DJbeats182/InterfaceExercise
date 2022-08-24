using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool TakesGas { get; set; }
        public bool IsConvertible { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasTrunk { get; set; }
        public int GasMileage { get; set; }
        public string Logo { get; set; }
        public int RevenueMade { get; set; }
    }
}
