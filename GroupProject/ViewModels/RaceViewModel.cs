using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProject.ViewModels
{
    public class RaceViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Classification { get; set; }

        public int AverageHeight { get; set; }

        public string Photo { get; set; }

        public List<RacePlanetPartialViewModel> Planets { get; set; }

    }
}