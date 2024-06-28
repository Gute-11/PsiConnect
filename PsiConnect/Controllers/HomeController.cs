using Microsoft.AspNetCore.Mvc;
using PsiConnect.Models;
using System.Diagnostics;

namespace PsiConnect.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error(int statusCode)
        {
            if (statusCode == 403)
            {
                return View("AccessDenied");
            }
            return View();
        }

    }
}
