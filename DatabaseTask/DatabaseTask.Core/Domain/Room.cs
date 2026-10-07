using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string RoomType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int RoomNr { get; set; }
        public int Floor { get; set; }
        public bool AirConditioner { get; set; }

        public ICollection<Bookable> Bookables { get; set; } = new List<Bookable>();
    }
}
