using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class PlanetDetails
    {
        [Key, ForeignKey("Planet")]
        public int PlanetID { get; set; }

        public virtual Planet Planet { get; set; }

        public int RotationPeriod { get; set; }

        public int OrbitalPeriod { get; set; }

        public int Diameter { get; set; }

        public long? Population { get; set; }

    }
}