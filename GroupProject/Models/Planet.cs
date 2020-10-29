using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace GroupProject.Models
{
    public class Planet
    {
        public int PlanetID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        public int? Gravity { get; set; }

        public int? SurfaceWater { get; set; }

        public string Url { get; set; }

        public string Photo { get; set; }

        public virtual ICollection<PlanetClimate> PlanetClimates { get; set; }

        public virtual ICollection<PlanetTerrain> PlanetTerrains { get; set; }

        public virtual ICollection<UserStatisticsPlanet> UserStatisticsPlanets { get; set; }

        public virtual ICollection<PlanetRace> PlanetRaces { get; set; }

        public virtual ICollection<PlanetUser> PlanetUsers { get; set; }

        public virtual ICollection<FlightDeparture> FlightDepartures { get; set; }

        public virtual ICollection<FlightDestination> FlightDestinations { get; set; }

    }
}