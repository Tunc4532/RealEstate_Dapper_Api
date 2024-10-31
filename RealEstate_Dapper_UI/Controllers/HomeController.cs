using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_UI.Models;
using System.Diagnostics;

namespace RealEstate_Dapper_UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
