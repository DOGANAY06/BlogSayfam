using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    
    //bir yerin üzerinden authorizate olmalıyız
    public class CustomerController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CustomerProfile()
        {
            return View();
        }
        
        public IActionResult CustomerMail()
        {
            return View();
        }
    }
}
