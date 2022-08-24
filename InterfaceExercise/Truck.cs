using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public bool TakesGas { get; set; }
        public bool IsConvertible { get; set; }      
        public int NumberOfSeats { get; set; }
        public bool HasBed { get; set; }
        public int TowCapacity { get; set; }
        public string Logo { get; set; }
        public string Slogan { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("Trucks go Aruga!");
        }
    }
}
