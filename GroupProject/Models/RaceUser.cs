using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class RaceUser
    {

        [Key, ForeignKey("User"), Column(Order = 0)]
        public int UserID { get; set; }

        [ForeignKey("Race"), Column(Order = 1)]
        public int RaceID { get; set; }

        public virtual Race Race { get; set; }

        public virtual User User { get; set; }
    }
}