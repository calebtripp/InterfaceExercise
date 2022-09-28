using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public bool HasMotor { get; set; }
        public string BodyColor { get; set; }
        public bool HasBrakes { get; set; }
        public int WheelNumber { get; set; }
    }
}
