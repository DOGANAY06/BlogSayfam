using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReviewService
    {
        void ReviewAdd(Review  review);
        void ReviewDelete(Review review);
        void ReviewUpdate(Review review);

        List<Review> GetListAll();
        Review GetById(int id);

        List<Review> GetReviewListWithCategory();
        //liste formatında görüşleri getir  categorylere göre listeyi getir

        List<Review> GetReviewListByCustomer(int id);
        //görüşleri kullanıcılara göre getir görüş id al
    }
}
