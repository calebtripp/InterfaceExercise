﻿using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Truck();          
            t1.LiftSize = 3;
            t1.ShockUpgrade = true;
            t1.HasMotor = true;
            t1.BodyColor = "Green";
            t1.HasBrakes = true;
            t1.WheelNumber = 4;
            t1.Mission = "to keep the world adventurous forever";
            t1.Recognizeable = false;

            var c1 = new Car();
            c1.LeatherInterior = true;
            c1.PassengerCap = 5;
            c1.HasMotor = true;
            c1.BodyColor = "Green";
            c1.HasBrakes = true;
            c1.WheelNumber = 4;
            c1.Mission = "to keep the world adventurous forever";
            c1.Recognizeable = false;

            var s1 = new SUV();
            s1.CargoSpace = 540;
            s1.HasTV = true;
            s1.HasMotor = true;
            s1.BodyColor = "Green";
            s1.HasBrakes = true;
            s1.WheelNumber = 4;
            s1.Mission = "to keep the world adventurous forever";
            s1.Recognizeable = false;





           // Public static void Print
                // is there a method to print all properties?






            //Creatively display and organize their values

            // method to print each 
            //method to add to list
            //method to join different types?
            // might this work?

//public static string GetAllProperties(object obj)
//            {
//                return string.Join(" ", obj.GetType()
//                                            .GetProperties()
//                                            .Select(prop => prop.GetValue(obj)));
//            }
          

//foreach (Galaxy theGalaxy in vehicleList)
//            {
//                Console.WriteLine(GetAllProperties(theGalaxy));
//            }



        }
    }
}
