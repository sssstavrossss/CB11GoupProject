using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class UserStatisticsPlanet
    {
        [Key, ForeignKey("UserStatistics"), Column(Order = 0)]
        public int UserID { get; set; }

        [Key, ForeignKey("Planet"), Column(Order = 1)]
        public int PlanetID { get; set; }

        public virtual UserStatistics UserStatistics { get; set; }

        public virtual Planet Planet { get; set; }
    }
}