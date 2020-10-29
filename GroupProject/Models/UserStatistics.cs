using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class UserStatistics
    {
        [Key,ForeignKey("User")]
        public int UserStatisticsID { get; set; }

        public int? PlanetsVisited { get; set; }
        public int? TerrainsVisited { get; set; }
        public int? ClimatesVisited { get; set; }
        public int? FlightsTotal { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<UserStatisticsPlanet> UserStatisticsPlanets { get; set; }
        public virtual ICollection<UserStatisticsClimate> UserStatisticsClimates { get; set; }
        public virtual ICollection<UserStatisticsTerrain> UserStatisticsTerrains { get; set; }
        public virtual ICollection<UserStatisticsFlight> UserStatisticsFlights { get; set; }
    }
}