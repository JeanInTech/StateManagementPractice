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
            List<string> koreaColors = new List<string> { "white", "red", "blue", "black" };
            List<string> japanColors = new List<string> { "white", "red" };
            List<string> usColors = new List<string> { "red", "white", "blue" };
            List<string> canadaColors = new List<string> { "red", "white" };
            List<string> chinaColors = new List<string> { "red", "yellow" };
        public IActionResult Index()
        {
            List<Country> Countries = new List<Country>
            {
                new Country("South Korea", "Korean", "Annyeonghaseyo", "Small peninsula in east Asia", koreaColors),
                new Country("Japan", "Japanese", "Konnichiwa", "Small island in east Asia", japanColors),
                new Country("United States", "American English", "Yeehaw", "Country sandwiched between Mexico and Canada", usColors),
                new Country("Canada", "English", "Eh?", "The northern part of North America", canadaColors),
                new Country("China", "Chinese", "Nihao", "Largest country in Asia", chinaColors)
            };

            return View("Countries", Countries);
        }
        [HttpPost]
        public IActionResult CountryDetails(int index)
        {
            List<Country> Countries = new List<Country>
            {
                new Country("South Korea", "Korean", "Annyeonghaseyo", "Small peninsula in east Asia", koreaColors),
                new Country("Japan", "Japanese", "Konnichiwa", "Small island in east Asia", japanColors),
                new Country("United States", "American English", "Yeehaw", "Country sandwiched between Mexico and Canada", usColors),
                new Country("Canada", "English", "Eh?", "The northern part of North America", canadaColors),
                new Country("China", "Chinese", "Nihao", "Largest country in Asia", chinaColors)
            };

            Country c = Countries[index];
            return View(c);
        }
    }
}
