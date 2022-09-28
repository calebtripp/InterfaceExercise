using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int CargoSpace { get; set; }
        public bool HasTV { get; set; }
        public bool HasMotor { get; set; }
        public string BodyColor { get; set; }
        public bool HasBrakes { get; set; }
        public int WheelNumber { get; set; }
        public string Mission { get; set; }
        public bool Recognizeable { get; set; }
    }
}
