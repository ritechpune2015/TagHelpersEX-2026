using Microsoft.AspNetCore.Mvc;

namespace TagHelpersEX.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string SayBye(string email, string name)
        {
            return $"email is:{email} and name is:{name}";
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
