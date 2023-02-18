using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Plannerico.Data.Models;

namespace Plannerico.Data
{
    public class PlannericoDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public PlannericoDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            this.configuration = configuration;
        }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<Attachment> Attachments { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Requirement> Requirements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(this.configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
