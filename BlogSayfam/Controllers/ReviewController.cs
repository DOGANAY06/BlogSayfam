using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    public class ReviewController : Controller
    {
        ReviewManager rm = new ReviewManager(new EfReviewRepository());
        public IActionResult Index()
        {
            var values = rm.GetReviewListWithCategory();
            //DÖNDÜR değerleri categorylerine göre
            return View(values);
        }
        public IActionResult ReviewReadAll(int id)
        {
            ViewBag.i = id;
            //view bag ile viewe veriyi taşıyoruz 
            var values = rm.GetReviewByID(id);
            //ıd e göre getir 
            return View(values);
        }
    }
}
