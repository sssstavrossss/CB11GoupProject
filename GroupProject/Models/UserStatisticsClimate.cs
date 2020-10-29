using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class UserStatisticsClimate
    {
        [Key, ForeignKey("UserStatistics"), Column(Order = 0)]
        public int UserID { get; set; }

        [Key, ForeignKey("Climate"), Column(Order = 1)]
        public int PlanetID { get; set; }

        public virtual UserStatistics UserStatistics { get; set; }

        public virtual Climate Climate { get; set; }
    }
}