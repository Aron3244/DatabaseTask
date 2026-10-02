using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Payroll
    {
        [Key]
        public int PayrollId { get; set; }

        public int EmployeeId { get; set; }

        public float Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
