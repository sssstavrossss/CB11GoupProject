using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class PlanetRace
    {
        [Key, ForeignKey("Planet"), Column(Order = 0)]
        public int PlanetID { get; set; }

        [Key, ForeignKey("Race"), Column(Order = 1)]
        public int RaceID { get; set; }

        public virtual Planet Planet { get; set; }

        public virtual Race Race { get; set; }
    }
}