using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Guests
    {
        [Key]
        public int GuestsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string PersonalID { get; set; }
        public string Citizenship { get; set; }
 

        public ICollection<Booking> ServicesOrders { get; set; } = new List<Booking>();
    }
}
