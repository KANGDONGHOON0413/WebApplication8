using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.DbConn;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult NewPage01()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewPage01(User model)
        {
            if (ModelState.IsValid)
            {
                using(var db = new Conn())
                {
                    var user = db.Users.FirstOrDefault(X => X.UserID.Equals(model.UserID) && X.UserPW.Equals(model.UserPW));
                    if(!(user is null))
                    {
                        return RedirectToAction("Privacy", "Home");
                    }
                }
            }



            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
