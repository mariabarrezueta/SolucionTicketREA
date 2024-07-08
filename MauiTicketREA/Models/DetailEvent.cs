using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTicketREA.Models
{
    public class DetailEvent
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventImage { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
    }
}
