using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Desktop.Models;

namespace Desktop.DAL
{
    public class HotelContext : DbContext
    {

        public HotelContext() : base("HotelContext")
        {
            Database.SetInitializer<HotelContext>(new HotelInitializer());
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}