﻿using AM.ApplicationCor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCor.Interfaces
{
   public interface IServiceFlight: IService<Flight>
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        double DurationAverage(string destination);
        IEnumerable<Flight> OrderedDurationFlights();
        IEnumerable<String> SeniorTravellers(Flight f);
        IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
}
