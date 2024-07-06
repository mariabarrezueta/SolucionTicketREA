using System.Collections.Generic;
using ApiTicketREA.Data.Models;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<Ticket> Ticket { get; set; } = default!;

    }
}