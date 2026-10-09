using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class FlightStatusChange
    {
        [Key]
        public int FlightStatusChangeId { get; set; }

        public DateTime ChangeDate { get; set; }
        public string reason { get; set; }

        public int FlightId { get; set; }
        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
    }
}
