using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Models.Interfaces;

namespace WebApplication3.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult MainPage(User user)
        {
            var connUser = _userService.GetUserByEmail(user.Email);
            if (connUser == null)
                return RedirectToAction("Login", "Account");
            if (user.Password == null)
                return RedirectToAction("Login", "Account");
            else if (connUser.Password == user.Password)
                return View(connUser);
            return RedirectToAction("Login", "Account");
        }
    }
}
