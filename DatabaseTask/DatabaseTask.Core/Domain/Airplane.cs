using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Airplane
    {
        [Key]
        public int AirplaneId { get; set; }

        public int RegistrationNumber { get; set; }

        public string Model { get; set; }

        public int NumberOfSeats { get; set; }

        public int YearOfManufacture { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
