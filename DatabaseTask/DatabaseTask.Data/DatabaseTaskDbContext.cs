using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }
        public DbSet<Bookable> Bookables { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Guests> Guestss { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Services> Servicess { get; set; }
        public DbSet<ServicesOrder> ServicesOrders { get; set; }
 

    }
}
