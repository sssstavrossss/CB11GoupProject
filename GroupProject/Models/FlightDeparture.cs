using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class FlightDeparture
    {
        [Key, Column(Order = 0)]
        public int FlightDepartureID { get; set; }

        [ForeignKey("Planet"), Column(Order = 1)]
        public int PlanetID { get; set; }

        public string Name { get; set; }

        public virtual Planet Planet { get; set; }

        public ICollection<Flight> Flights { get; set; }
    }
}