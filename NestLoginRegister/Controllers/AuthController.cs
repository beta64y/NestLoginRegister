using Microsoft.AspNetCore.Mvc;

namespace NestLoginRegister.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
