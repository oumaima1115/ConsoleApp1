using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCor.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
        public virtual Plane Plane { get; set; }
        public virtual List<Ticket> Tickets { get; set; }
        //public virtual List<Passenger> Passengers { get; set;}
        public string AirlineLogo { get; set; }

        //methods
        public override string ToString()
        {
            return "Destination: " + Destination +
                ", Departure: " + Departure +
                ", FlightDate: " + FlightDate +
                ", EffectiveArrival: " + EffectiveArrival;
        }

    }
}
