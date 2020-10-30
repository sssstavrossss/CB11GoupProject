using GroupProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GroupProject.ViewModels
{
    public class RaceViewModel
    {
        public int ID { get; set; }

        [DisplayName("Race Name")]
        public string Name { get; set; }

        [DisplayName("Classification")]
        public string Classification { get; set; }

        [DisplayName("Average Height")]
        public int AverageHeight { get; set; }

        [DisplayName("Photo")]
        public string Photo { get; set; }

        public List<int> PlanetsID { get; set; }

        public List<string> PlanetsName { get; set; }

    }
}