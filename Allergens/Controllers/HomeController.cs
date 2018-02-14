using Microsoft.AspNetCore.Mvc;
using Allergens.Models;
using System.Collections.Generic;

namespace Allergens.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpPost("/results")]
        public ActionResult Results()
        {
          Score newScore = new Score(int.Parse(Request.Form["score"]));
          List<Allergy> allAllergies = Allergy.GetAllAllergies();
          List<string> finalList = newScore.GetAllergyList(allAllergies);
          return View(finalList);
        }
    }
}
