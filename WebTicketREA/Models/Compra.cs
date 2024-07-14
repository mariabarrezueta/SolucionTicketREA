using System;
using System.ComponentModel.DataAnnotations;

namespace WebTicketREA.Models
{
    public class Compra
    {
        [Key]
        public int PurchaseId { get; set; }
        public string HolderName { get; set; }
        public string HolderId { get; set; }
        public int TicketQuantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string EventName { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardCode { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
