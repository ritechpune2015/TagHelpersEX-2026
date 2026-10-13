using Microsoft.AspNetCore.Mvc;

namespace TagHelpersEX.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string SayHello()
        {
            return "Say Hello Called!";
        }

        public string Save()
        {
            return "Save Called!";
        }
    }
}
