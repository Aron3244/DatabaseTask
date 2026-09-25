using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        [StringLength(20)]
        public string? Location { get; set; }

        public DateTime? CreateDate { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<TechSupport> TechSupports { get; set; } = new List<TechSupport>();
    }

    public class JobTitle
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        [StringLength(40)]
        public string? Description { get; set; }

        public ICollection<InternetAccess> InternetAccesses { get; set; } = new List<InternetAccess>();
    }

    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? FirstName { get; set; }

        [StringLength(20)]
        public string? LastName { get; set; }

        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [StringLength(20)]
        public string? Email { get; set; }

        [StringLength(20)]
        public string? IdentificationCode { get; set; }

        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company? Company { get; set; }

        public ICollection<Holidays> Holidays { get; set; } = new List<Holidays>();
        public ICollection<TechSupport> TechSupports { get; set; } = new List<TechSupport>();
        public ICollection<Sickness> Sicknesses { get; set; } = new List<Sickness>();
        public ICollection<BorrowList> BorrowLists { get; set; } = new List<BorrowList>();
        public ICollection<MedicalControlList> MedicalControlLists { get; set; } = new List<MedicalControlList>();
        public ICollection<InternetAccess> InternetAccesses { get; set; } = new List<InternetAccess>();
    }

    public class Holidays
    {
        [Key]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }

    public class TechSupport
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string? Description { get; set; }

        public int? CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company? Company { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }

    public class Sickness
    {
        [Key]
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }

        [StringLength(40)]
        public string? Description { get; set; }

        public DateTime? EndDate { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }

    public class BorrowList
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? Name { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }

    public class MedicalControlList
    {
        [Key]
        public int Id { get; set; }

        public DateTime? Date { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }

    public class InternetAccess
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string? AccessName { get; set; }

        public int? JobTitleId { get; set; }
        [ForeignKey(nameof(JobTitleId))]
        public JobTitle? JobTitle { get; set; }

        public int? EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }
    }
}