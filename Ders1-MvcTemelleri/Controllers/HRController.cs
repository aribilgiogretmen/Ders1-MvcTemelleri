using Ders1_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1_MvcTemelleri.Controllers
{
    public class HRController : Controller
    {
        private static List<HR> hr = new List<HR>
        {

            new HR{FirstName="Melike", lastName="Şahin",Age=30,Salary=500.00m},
            new HR{FirstName="Serdar", lastName="Ortaç",Age=55,Salary=25000.00m},
            new HR{FirstName="Sertap", lastName="Erener",Age=60,Salary=6500.00m}
        };

        [HttpGet("/Hr")]
        public IActionResult Index()
        {
            return View(hr);
        }
    }
}
