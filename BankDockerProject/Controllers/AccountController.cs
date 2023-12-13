using BankDockerProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankDockerProject.Controllers
{
    public class AccountController : Controller
    {
        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User model)
        {
           
                // Successful login, redirect to dashboard
                return RedirectToAction("Index", "Dashboard");
            }
            // Invalid login, show error message
           
    }
}
