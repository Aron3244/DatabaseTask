using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Terminal
    {
        [Key]
        public int TerminalId { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public ICollection<Gate> Gates { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
