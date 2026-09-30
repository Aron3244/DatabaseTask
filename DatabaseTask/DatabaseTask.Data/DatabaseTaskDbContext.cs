using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Kindergarten> DatabaseTask { get; set; }
        public DbSet<Kindergarten> Prisoner { get; set; }
        public DbSet<Kindergarten> Block { get; set; }
        public DbSet<Kindergarten> Chamber { get; set; }
        public DbSet<Kindergarten> Crime { get; set; }
        public DbSet<Kindergarten> Punishment { get; set; }
        public DbSet<Kindergarten> Guest { get; set; }
        public DbSet<Kindergarten> Visiting { get; set; }
        public DbSet<Kindergarten> Guard { get; set; }
        public DbSet<Kindergarten> Shift { get; set; }
        
        
    }
}
