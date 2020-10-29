using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class PlanetClimate
    {
        [Key, ForeignKey("Planet"), Column(Order = 0)]
        public int PlanetID { get; set; }

        [Key, ForeignKey("Climate"), Column(Order = 1)]
        public int ClimateID { get; set; }

        public virtual Planet Planet { get; set; }

        public virtual Climate Climate { get; set; }
    }
}