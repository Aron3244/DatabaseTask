using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Services
    {
        [Key]
        public int ServiceId { get; set; }
        public string ServiceType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }


        public ICollection<ServicesOrder> ServiceOrders { get; set; } = new List<ServicesOrder>();

    }
}
