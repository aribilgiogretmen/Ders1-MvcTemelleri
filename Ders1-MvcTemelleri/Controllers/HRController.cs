using Ders1_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1_MvcTemelleri.Controllers
{
    public class HRController : Controller
    {
        private static List<HR> hr = new List<HR>
        {

            new HR{FirstName="Melike", lastName="Şahin",Age=30},
            new HR{FirstName="Serdar", lastName="Ortaç",Age=55},
            new HR{FirstName="Sertap", lastName="Erener",Age=60}
        };

        [HttpGet("/Hr")]
        public IActionResult Index()
        {
            return View(hr);
        }
    }
}
