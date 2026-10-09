using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Flight
    {
        [Key]
        public int FlightId { get; set; }

        public DateTime DepartureDate { get; set; }

        public TimeSpan DepartureTime { get; set; }

        public string DepartureAirline { get; set; }

        public string DestinationAirline { get; set; }

        public DateTime ArrivalDate { get; set; }

        public int AirplaneId { get; set; }
        [ForeignKey("AirplaneId")]
        public Airplane Airplane { get; set; }

        public int GateId { get; set; }
        [ForeignKey("GateId")]
        public Gate Gate { get; set; }

        public int AirlineId { get; set; }
        [ForeignKey("AirlineId")]
        public Airline Airline { get; set; }

        public ICollection<Registration> Registrations { get; set; }
        public ICollection<FlightStatusChange> FlightStatusChanges
        { get; set; }
    }
}

