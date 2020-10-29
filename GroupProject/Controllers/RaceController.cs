using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GroupProject.Controllers
{
    [Route("Races")]
    public class RaceController : Controller
    {
        // GET: Race
        public ActionResult Index()
        {
            return Content("hi");
        }
    }
}