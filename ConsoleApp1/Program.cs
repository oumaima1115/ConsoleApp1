using System;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.ApplicationCore.Interfaces;
using AM.Infrastructure;
using AM.ApplicationCore.Domain;

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
            Plane plane3 = new Plane
            {
                PlaneType = PlaneType.Airbus,
                Capacity = 150,
                ManufactureDate = new DateTime(2015, 02, 03)
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

            //methodOne to do operations
            //using (var db = new AMContext())
            //{
            //    // create a new Plane object
            //    var planeNew = new Plane
            //    {
            //        PlaneType = PlaneType.Airbus,
            //        Capacity = 200,
            //        ManufactureDate = new DateTime(2018, 11, 10)
            //    };

            //    // create a new Flight object and assign the plane to it
            //    var flight = new Flight
            //    {
            //        FlightDate = new DateTime(2023, 06, 01),
            //        Departure = "JFK",
            //        Destination = "LHR",
            //        Plane = planeNew
            //    };

            //    // add the flight to the database and save changes
            //    db.Flights.Add(flight);
            //    db.SaveChanges();

            //    // display the details of the newly added flight
            //    Console.WriteLine("New Flight added successfully!");
            //    Console.WriteLine($"Flight ID: {flight.FlightId}");
            //    Console.WriteLine($"Flight Date: {flight.FlightDate.ToShortDateString()}");
            //    Console.WriteLine($"Departure Airport: {flight.Departure}");
            //    Console.WriteLine($"Arrival Airport: {flight.Destination}");
            //    Console.WriteLine($"Plane Type: {flight.Plane.PlaneType}");
            //    Console.WriteLine($"Plane Capacity: {flight.Plane.Capacity}");
            //    Console.WriteLine($"Plane Manufacture Date: {flight.Plane.ManufactureDate.ToShortDateString()}");
            //}

            /////Hedhi kifha////

            AMContext ctx = new AMContext();
            //instanciation des objets
            Plane plane1 = new Plane
            {
                PlaneType = PlaneType.Airbus,
                Capacity = 150,
                ManufactureDate = new DateTime(2015, 02, 03)
            };

            Flight f1 = new Flight()
            {
                Departure = "Tunis",
                FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
                Destination = "Paris",
                AirlineLogo = "new",
                EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
                EstimatedDuration = 103,
                Plane = plane1
            };

            //Ajouter des objets aux DBSET
            ctx.Planes.Add(plane1);
            ctx.Flights.Add(f1);

            //persister les données
            ctx.SaveChanges();
            Console.WriteLine(f1.Plane.PlaneId + " " + f1.Plane.Capacity);
            Console.WriteLine(plane1.PlaneId + " " + plane1.Capacity);

            //Method TWO
            //AMContext ctx = new AMContext();

            //Plane p1 = new Plane()
            //{
            //    PlaneType = PlaneType.Airbus,
            //    Capacity = 150,
            //    ManufactureDate = new DateTime(2015, 02, 03)
            //};
            //Flight f1 = new Flight()
            //{
            //    Departure = "Tunis",
            //    FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
            //    Destination = "Paris",
            //    EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
            //    EstimatedDuration = 103,
            //    Plane = p1
            //};

            //Type type = typeof(ServiceFlight);
            //IUnitOfWork unitOfWork = new UnitOfWork(ctx,type);
            //IServiceFlight serviceFlight = new ServiceFlight(unitOfWork);

            //serviceFlight.Add(f1);

            //ctx.SaveChanges();

        }
    }
}