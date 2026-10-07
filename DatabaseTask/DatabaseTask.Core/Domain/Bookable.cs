using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Bookable
    {
        [Key]
        public int BookingId { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleCount { get; set; }
        public string PaymentMethod { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal RoomAmount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }

        public int GuestId { get; set; }
        [ForeignKey("GuestId")]
        public Guests Guests { get; set; }

        public Guid EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
        public ICollection<ServicesOrder> ServiceOrders { get; set; } = new List<ServicesOrder>();
        public ICollection<Bookable> Bookables { get; set; } = new List<Bookable>();
    }
}

