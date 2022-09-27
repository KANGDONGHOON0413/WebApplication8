﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.DataContext;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class MyInfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new DContext())
                {
                    db.Add(model);
                    if (db.SaveChanges() > 0) return RedirectToAction("Privacy", "Home");
                }
            }
            return View();
        }

    }
}
