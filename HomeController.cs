using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace routing_tempdata.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> ENGLISHMONTHS = new List<string>
            {
                "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
            };

            TempData["ENGLISHMONTHS"] = ENGLISHMONTHS;

            return View();
        }
    }
}
