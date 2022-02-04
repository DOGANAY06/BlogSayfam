using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.ViewComponents.Comment
{
    public class CommentListByReview : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        { //çağır anlamında Invoke id den gelen değeri
            var values = cm.GetList(id);
            return View(values);

        }
    }
}
