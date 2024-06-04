using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;

namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.username = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do not match! Try again!";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}

