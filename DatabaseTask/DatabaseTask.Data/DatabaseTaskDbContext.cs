using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using static DatabaseTask.Core.Domain.DatabaseTask;


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
    }
}
