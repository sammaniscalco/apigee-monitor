using Microsoft.EntityFrameworkCore;

namespace apigee_monitor.Models
{
    public class ServerContext : DbContext
    {
        public ServerContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<Server> Servers { get; set; }
    }
}
