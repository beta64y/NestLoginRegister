using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NestLoginRegister.Models;
using NestLoginRegister.ViewModel;

namespace NestLoginRegister.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser appUser = new AppUser()
            {
                UserName = registerViewModel.Username,
                Email = registerViewModel.Email,
                IsActive = true,


            };
            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerViewModel.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {

                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
