using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Globalization;

namespace Assignment1.Controllers
{
    public class SignUpController : Controller
    {
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {                      
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        
        public IActionResult SignUp() 
        {
            List<SelectListItem> Country = new List<SelectListItem>();
            Country.Add(new SelectListItem { Text = "India", Value = "1" });
            Country.Add(new SelectListItem { Text = "America", Value = "2" });
            //Country.Sort();            
            ViewBag.CountryList = new SelectList(Country, "Value", "Text");           


            return View();
        }

        [HttpGet]
        public IActionResult GetCityByCountryId(int countryId)
        {
            SignUpModel model = new SignUpModel();

            return Json(model.GetCityByCountryId(Convert.ToInt32(countryId)));
        }
    }
}
