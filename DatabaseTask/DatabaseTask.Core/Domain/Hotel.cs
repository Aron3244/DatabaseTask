using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }

        public string Address { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public DateTime RegistrationDate { get; set; }

        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int RoomCount { get; set; }
        public Employee? Employee { get; set; }

     
    }
}
