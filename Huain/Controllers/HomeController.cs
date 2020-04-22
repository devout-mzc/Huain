using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Huain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Huain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public  IActionResult Login(LoginViewModel model,string returnUrl=null)
        {
            if (ModelState.IsValid)
            { 
            
            }
            return View(model);
        }
    }
}