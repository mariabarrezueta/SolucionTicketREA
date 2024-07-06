using System.Collections.Generic;
using WebTicketREA.Models;
using Microsoft.EntityFrameworkCore;

namespace WebTicketREA.Data
{
    public class WebTicketREAContext : DbContext
    {
        public WebTicketREAContext(DbContextOptions<WebTicketREAContext> options)
            : base(options)
        {
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<DetailEvent> DetailEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WebTicketREA.Models.Ticket> Ticket { get; set; } = default!;

    }
}