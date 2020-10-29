using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class StarShip
    {
        public int StarShipID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public double Length { get; set; }

        [Required]
        public int Crew { get; set; }

        [Required]
        public int Passengers { get; set; }

        [Required]
        public int CargoCapacity { get; set; }

        public string Photo { get; set; }

        [Required]
        public double HyperdriveRating { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}