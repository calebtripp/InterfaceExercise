using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int LiftSize { get; set; }
        public bool ShockUpgrade { get; set; }
        public bool HasMotor { get; set; }
        public string BodyColor { get; set; }
        public bool HasBrakes { get; set; }
        public int WheelNumber { get; set; }
        public string Mission { get; set; }
        public bool Recognizeable { get; set; }
    }
}
