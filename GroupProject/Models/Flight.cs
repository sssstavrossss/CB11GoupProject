using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Flight
    {
        [Key, Column(Order = 0)]
        public int FlightID { get; set; }

        [ForeignKey("FlightDeparture"), Column(Order = 1)]
        public int FlightDepartureID { get; set; }

        [ForeignKey("FlightDestination"), Column(Order = 2)]
        public int FlightDestinationID { get; set; }

        public DateTime Date { get; set; }

        public int Interval { get; set; }

        public decimal Distance { get; set; }

        public int Time { get; set; }

        public decimal Price { get; set; }

        public virtual FlightDeparture FlightDeparture { get; set; }

        public virtual FlightDestination FlightDestination { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<UserStatisticsFlight> UserStatisticsFlights { get; set; }

    }
}