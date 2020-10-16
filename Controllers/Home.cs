using Microsoft.AspNetCore.Mvc;

namespace Rehber.Controllers
{
    public class Home : Controller
    {
        // GET
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}