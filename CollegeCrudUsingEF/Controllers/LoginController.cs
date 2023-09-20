using DataAccessLibrary.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCrudUsingEF.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Loginpage()
        {
            return View(new LoginModel());
        }

        public IActionResult Login(LoginModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //return Redirect("/Product/List");


                }
                return Redirect("/Student/List");
            }
            catch
            {
                return View();
            }
        }
    }
}
