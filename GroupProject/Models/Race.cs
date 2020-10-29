using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Race
    {
        
        public int RaceID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Classification { get; set; }

        public int AverageHeight { get; set; }

        public string Url { get; set; }

        public string Photo { get; set; }

        public virtual ICollection<RaceUser> RaceUsers { get; set; }

        public virtual ICollection<PlanetRace> PlanetRaces { get; set; }

    }
}