using Microsoft.EntityFrameworkCore;
using OpenDoor.Entitty;

namespace OpenDoor.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<ApplicantEntity> Applicants { get; set; } = null;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=open_door;user=root;password=123456789",
                new MySqlServerVersion(new Version(8, 0, 40)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicantEntity>(applicant =>
            {
                applicant.HasKey(a => a.Id);
            });
        }

    }
}
