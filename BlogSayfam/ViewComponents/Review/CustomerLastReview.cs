using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.ViewComponents.Review
{
    public class CustomerLastReview:ViewComponent
    {
        ReviewManager rm = new ReviewManager(new EfReviewRepository());

        public IViewComponentResult Invoke()
        {
            var values = rm.GetReviewListByCustomer(1);
            //listeyi döndür
            return View(values);
        }
    }
}
