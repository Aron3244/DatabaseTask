using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using static DatabaseTask.Core.Domain.DatabaseTask;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

    
        public DbSet<Prison> Prisons { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Chamber> Chambers { get; set; }
        public DbSet<Prisoner> Prisoners { get; set; }
        public DbSet<Crime> Crimes { get; set; }
        public DbSet<Punishment> Punishments { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Visiting> Visitings { get; set; }
        public DbSet<Guard> Guards { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Holidays> Holidays { get; set; }
        public DbSet<TechSupport> TechSupports { get; set; }
        public DbSet<Sickness> Sicknesses { get; set; }
        public DbSet<BorrowList> BorrowLists { get; set; }
        public DbSet<MedicalControlList> MedicalControlLists { get; set; }
        public DbSet<InternetAccess> InternetAccesses { get; set; }
    }
}
