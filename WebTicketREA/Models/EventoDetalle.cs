using System.ComponentModel.DataAnnotations;

namespace WebTicketREA.Models
{
    public class EventoDetalle
    {
        [Key]
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventImage { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public decimal TicketPrice { get; set; }// Nueva propiedad
    }
}

