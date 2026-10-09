using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }
    }
}
