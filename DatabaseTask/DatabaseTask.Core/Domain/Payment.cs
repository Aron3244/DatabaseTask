using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }

        public int EmployeeId { get; set; }
        public int GuestId { get; set; }
        public int BookingId { get; set; }
    }
}
