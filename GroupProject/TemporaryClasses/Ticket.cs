using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int FlightID { get; set; }

        public virtual Flight Flight { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }
        public string Seat { get; set; }
    }
}