using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous] //bütün kurallardan muafsen giriş yapılsın diye yapıyoruz burayı 
        public IActionResult Index()
        {
            return View();
        }
    }
}
