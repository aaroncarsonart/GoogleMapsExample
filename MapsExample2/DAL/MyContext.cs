using MapsExample2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MapsExample2.DAL
{
    public class MyContext : DbContext
    {

        public MyContext()
            : base("MyContext")
        {
        }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}