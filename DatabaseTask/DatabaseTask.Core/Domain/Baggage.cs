using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Baggage
    {
        [Key]
        public int BaggageId { get; set; }

        public int BagNumber { get; set; }

        public decimal Weight { get; set; }

        public string BaggageType { get; set; }

        public int RegistrationId { get; set; }
        [ForeignKey("RegistrationId")]
        public Registration Registration { get; set; }
    }
}
