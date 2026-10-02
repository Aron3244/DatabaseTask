using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {

        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public  string Posision { get; set; }
        public  string Telephone { get; set; }
        public  string Email { get; set; }
        public  string Address { get; set; }
        public  DateTime StartDate { get; set; }
        public  DateTime EndDate { get; set; }
        public  string PersonalId { get; set; }
        public int HotelID { get; set; }
   

        public ICollection<Hotel> Prisoners { get; set; } = new List<Hotel>();

    }
}
