using Esky_deployment.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Esky_deployment.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Chargers> Chargers { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<SimPackages> SimPackages { get; set; }
        public DbSet<Sims> Sims {get;set;}
    }
}