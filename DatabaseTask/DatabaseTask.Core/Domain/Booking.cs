using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleCount { get; set; }
        public string PaymentMethod { get; set; }
        public decimal RoomAmount { get; set; }
        public decimal Cost { get; set; }

        public int GuestId { get; set; }
    }
}
