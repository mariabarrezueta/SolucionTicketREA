using System.ComponentModel.DataAnnotations;

namespace WebTicketREA.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int EventoDetalleId { get; set; }
        public EventoDetalle EventoDetalle { get; set; }
    }
}
