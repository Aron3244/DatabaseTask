using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public DateTime RegistrationData { get; set; }

        [Column(TypeName = "decimal(3,1)")]
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public int RoomCount { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}