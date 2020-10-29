using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class History
    {
        public int HistoryID { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }

        public long TotalMiles { get; set; }
        public ICollection<Planet> Planets { get; set; }
        public decimal TotalMoneySpend { get; set; }

        public virtual Ticket Tickets { get; set; }
    }
}