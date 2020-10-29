using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class Climate : ITerra
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Photo { get; set; }

        public virtual ICollection<PlanetClimate> PlanetClimates { get; set; }
        public virtual ICollection<UserStatisticsClimate> UserStatisticsClimates { get; set; }
    }
}