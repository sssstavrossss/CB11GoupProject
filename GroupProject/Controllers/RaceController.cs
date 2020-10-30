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
                .Include(r => r.PlanetRaces)
                .ToList();

            var viewModel = new List<RaceViewModel>();

            foreach (var race in races)
            {

                var racePlanets = new List<RacePlanetPartialViewModel>();

                foreach (var planetRace in race.PlanetRaces)
                {
                    racePlanets.Add(new RacePlanetPartialViewModel
                    {
                        ID = planetRace.PlanetID,
                        Name = db.Planets.Find(planetRace.PlanetID).Name
                    });
                }

                viewModel.Add(new RaceViewModel
                {
                    ID = race.RaceID,
                    Classification = race.Classification,
                    AverageHeight = race.AverageHeight,
                    Name = race.Name,
                    Photo = race.Photo,
                    Planets = racePlanets
                }) ;
                
            }

            return View(viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}