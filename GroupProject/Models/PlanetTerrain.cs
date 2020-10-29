using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class PlanetTerrain
    {
        [Key, ForeignKey("Planet"), Column(Order = 0)]
        public int PlanetID { get; set; }

        [Key, ForeignKey("Terrain"), Column(Order = 1)]
        public int TerrainID { get; set; }

        public virtual Planet Planet { get; set;}

        public virtual Terrain Terrain { get; set; }
    }
}