using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TagHelpersEX.Models;

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
            var lst = Category.GetCategories();
            ViewBag.Categories = new SelectList(lst, "CategoryID", "CategoryName");
            return View();
        }
    }
}
