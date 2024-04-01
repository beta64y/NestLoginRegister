using Microsoft.AspNetCore.Mvc;

namespace NestLoginRegister.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
