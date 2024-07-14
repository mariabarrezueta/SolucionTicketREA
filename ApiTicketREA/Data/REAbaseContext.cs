using Microsoft.EntityFrameworkCore;
using ApiTicketREA.Data.Models;

namespace ApiTicketREA.Data
{
    public class REAbaseContext : DbContext
    {
        public REAbaseContext(DbContextOptions<REAbaseContext> options)
            : base(options)
        {
        }

        public DbSet<Compra> Compras { get; set; }
        public DbSet<EventoDetalle> EventoDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Compra>().ToTable("Compra");
            modelBuilder.Entity<EventoDetalle>().ToTable("DetailEvents");

            modelBuilder.Entity<Compra>()
                .Property(c => c.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<EventoDetalle>()
                .Property(e => e.TicketPrice)
                .HasColumnType("decimal(18,2)");
        }
    }
}

