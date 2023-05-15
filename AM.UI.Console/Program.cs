using System;
using AM.ApplicationCor.Domain;

namespace AM.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Plane plane = new Plane();
            plane.Capacity = 200;
            plane.PlaneType = PlaneType.Airbus;
            plane.ManufactureDate = new DateTime(2018, 11, 10);

            Plane plane2 = new Plane(PlaneType.Boing,300,DateTime.Now);
            /*Plane plane3 = new Plane
            {
                PlaneType= PlaneType.Airbus,
                Capacity=150,
                ManufactureDate = new DateTime(2015,0,03)
            };*/
            Console.WriteLine("Plane2: " , plane2.ToString());




        }
    }
}
