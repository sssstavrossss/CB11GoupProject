﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GroupProject.ViewModels
{
    public class RacePlanetPartialViewModel
    {
        public int ID { get; set; }

        [DisplayName("Home Planets")]
        public string Name { get; set; }
    }
}