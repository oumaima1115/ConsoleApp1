using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCor.Domain
{
    public enum PlaneType
    {
        Boing,Airbus
    }
    public class Plane
    {
        public int PlaneId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "The Capacity must be a positive integer.")]
        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual List<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "Capacity: " + Capacity +
                ", ManufactureDate: " + ManufactureDate +
                ", PlaneType: " + PlaneType;
        }
        public Plane() { } // Add a parameterless constructor
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.PlaneType = pt;
            this.Capacity = capacity;
            this.ManufactureDate = date;
        }
    }
}
