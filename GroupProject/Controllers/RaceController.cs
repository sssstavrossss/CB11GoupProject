using GroupProject.DAL;
using GroupProject.Models;
using GroupProject.ViewModels;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    [RoutePrefix("Races")]
    public class RaceController : Controller
    {

        private GroupProjectContext db = new GroupProjectContext(); 

        // GET: Race
        [Route("Index")]
        public ActionResult Index()
        {

            var races = db.Races
                .Include(r => r.PlanetRaces);

            var viewModel = new List<RaceViewModel>();

            foreach (var race in races)
            {
                viewModel.Add(new RaceViewModel
                {
                    ID = race.RaceID,
                    Classification = race.Classification,
                    AverageHeight = race.AverageHeight,
                    Name = race.Name,
                    Photo = race.Photo,
                    Planets = new List<RacePlanetPartialViewModel>()
                }) ;
            }

            return View(viewModel);
        }
    }
}