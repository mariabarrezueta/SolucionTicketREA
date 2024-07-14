using Microsoft.EntityFrameworkCore;
using WebTicketREA.Models;

namespace WebTicketREA.Data
{
    public class WebTicketREAContext : DbContext
    {
        public WebTicketREAContext(DbContextOptions<WebTicketREAContext> options)
            : base(options)
        {
        }

        public DbSet<EventoDetalle> DetailEvents { get; set; }
        public DbSet<Compra> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventoDetalle>().ToTable("DetailEvents");
            modelBuilder.Entity<Compra>().ToTable("Events");
            modelBuilder.Entity<Ticket>().ToTable("Tickets");

            modelBuilder.Entity<Compra>()
                .Property(c => c.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<EventoDetalle>()
                .Property(e => e.TicketPrice)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Ticket>()
                .Property(t => t.Price)
                .HasColumnType("decimal(18,2)");
        }
    }
}
