using Microsoft.EntityFrameworkCore;

namespace apigee_monitor.Models
{
    public class ComponentContext : DbContext
    {
        public ComponentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Component> Components { get; set; }
    }
}
