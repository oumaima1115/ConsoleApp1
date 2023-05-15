using System;
using AM.ApplicationCor.Domain;

namespace ConsoleApp1
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

            Plane plane2 = new Plane(PlaneType.Boing, 300, DateTime.Now);
            Plane plane3 = new Plane{
                PlaneType= PlaneType.Airbus,
                Capacity=150,
                ManufactureDate = new DateTime(2015,02,03)
            };
            Console.WriteLine("Plane2: {0}", plane2.ToString());
            Console.WriteLine("Plane3: {0}", plane3.ToString());

            Passenger passenger = new Passenger();
            passenger.FullName = new FullName { FirstName = "John", LastName = "Doe" };
            Console.WriteLine(passenger.CheckProfile(passenger.FullName.FirstName, passenger.FullName.LastName));


            passenger.PassengerType();

            Staff staff = new Staff();
            staff.PassengerType();

            Traveller traveller = new Traveller();
            traveller.PassengerType();


        }
    }
}
