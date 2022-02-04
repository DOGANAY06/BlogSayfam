using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        //cm nesnesi aracılığıyla bütün metotlara erişim sağlayabiliriz
        public IActionResult Index()
        {
            var values = cm.GetList(); //bütün verileri getir
            return View(values);
        }
    }
}
