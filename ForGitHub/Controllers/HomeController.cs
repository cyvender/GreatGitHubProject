using System.Diagnostics;
using ForGitHub.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForGitHub.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
