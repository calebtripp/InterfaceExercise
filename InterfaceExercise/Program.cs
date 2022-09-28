using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicleList = new List<IVehicle>();

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

            vehicleList.Add(t1);
            vehicleList.Add(c1);
            vehicleList.Add(s1);

            foreach (var iVehicle in vehicleList)
            {
                Console.WriteLine(iVehicle.GetType().Name);            //system.reflection
                Console.WriteLine(JsonConvert.SerializeObject(iVehicle, Formatting.Indented));
                Console.WriteLine();
            }

            //works but is messier
            // static string GetAllProperties(object obj)
            //{
            //    return string.Join(" ", obj.GetType()
            //                                .GetProperties()
            //                                .Select(prop => prop.GetValue(obj)));
            //}


            //foreach (var listedVehicle in vehicleList)
            //{
            //    Console.WriteLine(GetAllProperties(listedVehicle));
            //}

        }
    }
}
