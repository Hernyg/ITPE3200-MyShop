using Microsoft.AspNetCore.Mvc;

namespace MyShop.Controllers
{
    public class HomeController : Controller
    {
        //GET: /<controllers>/
        public IActionResult Index()
        {
            return View();
        }
    }
}