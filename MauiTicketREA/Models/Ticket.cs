using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTicketREA.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string HolderName { get; set; }
        public string IdentityNumber { get; set; }
        public int TicketQuantity { get; set; }
        public string TicketCategory { get; set; }
        public decimal TotalAmountPaid { get; set; }
    }
}
