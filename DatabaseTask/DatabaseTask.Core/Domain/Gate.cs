using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Gate
    {
        [Key]
        public int GateId { get; set; }

        public int GateNumber { get; set; }

        public string Location { get; set; }

        public int MaximumAircraftSize { get; set; }

        public int TerminalId { get; set; }
        [ForeignKey("TerminalId")]
        public Terminal Terminal { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}
