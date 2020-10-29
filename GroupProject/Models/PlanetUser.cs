using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class PlanetUser
    {

        [Key, ForeignKey("User"), Column(Order = 0)]
        public int UserID { get; set; }

        [ForeignKey("Planet"), Column(Order = 1)]
        public int PlanetId { get; set; }

        public virtual Planet Planet { get; set; }

        public virtual User User { get; set; }
    }
}