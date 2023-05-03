namespace EventManagementSystem.Data
{
    using Microsoft.EntityFrameworkCore;

    namespace EventManagementSystem.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Event> Events { get; set; }
            public DbSet<Ticket> Tickets { get; set; }
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Ticket>()
                    .HasKey(t => new { t.EventId, t.UserId });

                modelBuilder.Entity<Ticket>()
                    .HasOne(t => t.Event)
                    .WithMany(e => e.Tickets)
                    .HasForeignKey(t => t.EventId);

                modelBuilder.Entity<Ticket>()
                    .HasOne(t => t.User)
                    .WithMany(u => u.Tickets)
                    .HasForeignKey(t => t.UserId);
            }
        }
    }

}
