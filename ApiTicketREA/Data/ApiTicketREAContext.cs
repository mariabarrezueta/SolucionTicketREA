using Microsoft.EntityFrameworkCore;
using ApiTicketREA.Data.Models;

namespace ApiTicketREA.Data
{
    public class ApiTicketREAContext : DbContext
    {
        public ApiTicketREAContext(DbContextOptions<ApiTicketREAContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<DetailEvent> DetailEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
                .Property(t => t.TotalAmountPaid)
                .HasColumnType("decimal(18,2)");
        }
    }
}

