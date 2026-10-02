using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ServicesOrder
    {
        [Key]
        public int ServiceOrderId { get; set; }

        public int ServiceId { get; set; }
        public int BookingId { get; set; }

        public DateTime Date { get; set; }
    }
}
