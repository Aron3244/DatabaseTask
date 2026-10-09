using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Registration
    {
         
      [Key]
    public int RegistrationId { get; set; }

    public int SeatNumber { get; set; }

    public int RegistrationTime { get; set; }

    public string TicketType { get; set; }

    public int PassengerId { get; set; }
    [ForeignKey("PassengerId")]
    public Passenger Passenger { get; set; }

    public int FlightId { get; set; }
    [ForeignKey("FlightId")]
    public Flight Flight { get; set; }

    public ICollection<Baggage> Baggages { get; set; }
    
    }
}
