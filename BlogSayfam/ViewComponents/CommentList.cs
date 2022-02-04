using BlogSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        { //çağır anlamında Invoke
            var commentvalues = new List<UserComment>
            {//yorum değerlerini UserComment isimli sınıftan alıcaz
                new UserComment
                {
                    ID =1,
                    Username = "Doğan"
                },
                 new UserComment
                {
                    ID =2,
                    Username = "Cengiz"
                },
                  new UserComment
                {
                    ID =3,
                    Username = "Selcuk"
                }
            };

            return View(commentvalues);
        }
    }
}
