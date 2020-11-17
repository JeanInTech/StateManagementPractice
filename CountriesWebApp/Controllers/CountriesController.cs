using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CountriesWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CountriesWebApp.Controllers
{
    public class CountriesController : Controller
    {
        List<Country> Countries = new List<Country>
            {
                new Country("South Korea", "Korean", "Annyeonghaseyo", "Small peninsula in east Asia", new List<string> { "white", "red", "blue", "black" }),
                new Country("Japan", "Japanese", "Konnichiwa", "Small island in east Asia", new List<string> { "white", "red" }),
                new Country("United States", "American English", "Yeehaw", "Country sandwiched between Mexico and Canada", new List<string> { "red", "white", "blue" }),
                new Country("Canada", "English", "Eh?", "The northern part of North America", new List<string> { "red", "white" }),
                new Country("China", "Chinese", "Nihao", "Largest country in Asia", new List<string> { "red", "yellow" })
            };
        public IActionResult Index()
        {
            return View("Countries", Countries);
        }
        [HttpPost]
        public IActionResult CountryDetails(int index)
        {
            Country c = Countries[index];
            ViewBag.cname = c.Name;
            TempData["MoreStuff"] = c.Description;
            return View(c);
        }
        public IActionResult CountryDescription()
        {
            return View();
        }
    }
}
