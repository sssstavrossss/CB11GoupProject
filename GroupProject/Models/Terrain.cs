using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Terrain : ITerra
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<PlanetTerrain> PlanetTerrains { get; set; }
        public virtual ICollection<UserStatisticsTerrain> UserStatisticsTerrains { get; set; }
    }
}