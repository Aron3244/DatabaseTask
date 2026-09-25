using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class DatabaseTask
    {
        public class Prison
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? PrisonName { get; set; }

            [StringLength(20)]
            public string? Location { get; set; }

            public int? Capacity { get; set; }

            public ICollection<Block> Blocks { get; set; } = new List<Block>();
            public ICollection<Guard> Guards { get; set; } = new List<Guard>();
        }

        public class Block
        {
            [Key]
            public int Id { get; set; }

            public int? BlockNumber { get; set; }

            [StringLength(20)]
            public string? BlockName { get; set; }

            public int? SecurityLevel { get; set; }

            public int? PrisonId { get; set; }
            [ForeignKey(nameof(PrisonId))]
            public Prison? Prison { get; set; }

            public ICollection<Chamber> Chambers { get; set; } = new List<Chamber>();
        }

        public class Chamber
        {
            [Key]
            public int Id { get; set; }

            public int? ChamberNumber { get; set; }
            public int? FloorNumber { get; set; }
            public int? Capacity { get; set; }

            public int? BlockId { get; set; }
            [ForeignKey(nameof(BlockId))]
            public Block? Block { get; set; }

            public ICollection<Prisoner> Prisoners { get; set; } = new List<Prisoner>();
        }

        public class Prisoner
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? FirstName { get; set; }

            [StringLength(20)]
            public string? LastName { get; set; }

            public DateTime? BirthOfDate { get; set; }
            public DateTime? ArivelDate { get; set; }

            public int? PersonalId { get; set; }

            [StringLength(20)]
            public string? Status { get; set; }

            public int? ChamberId { get; set; }
            [ForeignKey(nameof(ChamberId))]
            public Chamber? Chamber { get; set; }

            public ICollection<Crime> Crimes { get; set; } = new List<Crime>();
            public ICollection<Punishment> Punishments { get; set; } = new List<Punishment>();
            public ICollection<Visiting> Visitings { get; set; } = new List<Visiting>();
        }

        public class Crime
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? Name { get; set; }

            [StringLength(100)]
            public string? Description { get; set; }

            public int? GradeOfCrime { get; set; }
            public DateTime? ArivelDate { get; set; }

            public int? PersonalId { get; set; }

            [StringLength(20)]
            public string? Status { get; set; }

            public int? PrisonerId { get; set; }
            [ForeignKey(nameof(PrisonerId))]
            public Prisoner? Prisoner { get; set; }
        }

        public class Punishment
        {
            [Key]
            public int Id { get; set; }

            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }

            [StringLength(50)]
            public string? TypeOfPunishment { get; set; }

            public DateTime? ArivelDate { get; set; }

            public int? PersonalId { get; set; }

            [StringLength(20)]
            public string? Status { get; set; }

            public int? PrisonerId { get; set; }
            [ForeignKey(nameof(PrisonerId))]
            public Prisoner? Prisoner { get; set; }
        }

        public class Guest
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? FirstName { get; set; }

            [StringLength(20)]
            public string? LastName { get; set; }

            public int? PersonalId { get; set; }

            [StringLength(20)]
            public string? PhoneNumber { get; set; }

            [StringLength(20)]
            public string? Relationship { get; set; }

            public ICollection<Visiting> Visitings { get; set; } = new List<Visiting>();
        }

        public class Visiting
        {
            [Key]
            public int Id { get; set; }

            public DateTime? RegistryDate { get; set; }
            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }

            [StringLength(40)]
            public string? Status { get; set; }

            public int? GuestId { get; set; }
            [ForeignKey(nameof(GuestId))]
            public Guest? Guest { get; set; }

            public int? PrisonerId { get; set; }
            [ForeignKey(nameof(PrisonerId))]
            public Prisoner? Prisoner { get; set; }
        }

        public class Guard
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? FirstName { get; set; }

            [StringLength(20)]
            public string? LastName { get; set; }

            [StringLength(20)]
            public string? JobTitle { get; set; }

            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? Date { get; set; }

            public int? PrisonId { get; set; }
            [ForeignKey(nameof(PrisonId))]
            public Prison? Prison { get; set; }

            public ICollection<Shift> Shifts { get; set; } = new List<Shift>();
        }

        public class Shift
        {
            [Key]
            public int Id { get; set; }

            [StringLength(20)]
            public string? FirstName { get; set; }

            [StringLength(20)]
            public string? LastName { get; set; }

            public DateTime? StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public DateTime? Date { get; set; }

            public int? GuardId { get; set; }
            [ForeignKey(nameof(GuardId))]
            public Guard? Guard { get; set; }
        }
    }
}
