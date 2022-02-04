using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    public class CommentController : Controller
    {//Yorumları kontrol edeceğiz
        CommentManager cm = new CommentManager(new EfCommentRepository());
        //cm nesnesi aracılığıyla bütün metotlara erişim sağlayabiliriz
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.ReviewID = 4;
            cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentListByReview(int id)
        {//görüşlerdeki yorumlar
            var values = cm.GetList(id); //id den gelen değere göre alıcak 
            return PartialView(values);
        }
    }
}
