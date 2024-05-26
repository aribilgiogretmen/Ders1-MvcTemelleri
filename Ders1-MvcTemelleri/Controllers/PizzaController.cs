using Ders1_MvcTemelleri.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ders1_MvcTemelleri.Controllers
{
    public class PizzaController : Controller
    {
        [Route("PizzaSiparis")]
        [HttpGet] 
        public IActionResult Index()
        {

            Pizza pizza = new Pizza()
            {
                isim = "margherita",
                malzeme="Dometes,Peynir,Fesleğen",
                fiyat=300.00m
            };

            return View(pizza);
        }

       
        
    }
}
