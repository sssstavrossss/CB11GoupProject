using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Web;

namespace GroupProject.Models
{
    public class User
    {
        public int UserID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string FirstName { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        public string Photo { get; set; }


        [StringLength(10, MinimumLength = 10)]
        public string Identification { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string NickName { get; set; }

        [Required]
        public string Password { get; set; }

        //public string PaymentInfo { get; set; }

        //public Gender Gender { get; set; }

        public virtual RaceUser RaceUser { get; set; }

        public virtual PlanetUser PlanetUser { get; set; }

        public virtual UserStatistics UserStatistics { get; set; }

    }
}