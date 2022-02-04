using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        IReviewDal _reviewDal;

        public ReviewManager(IReviewDal reviewDal)
        {
            _reviewDal = reviewDal;
        }

        public Review GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewByID(int id )
        {//id göre blog getir 
            return _reviewDal.GetListAll(x => x.ReviewID == id);
            //dışarıdan gelen verilere göre listele benim verimi 
        }

        public List<Review> GetList()
        {
            return _reviewDal.GetListAll();
            //bütün liste değerlerini getir
        }

        public List<Review> GetReviewListWithCategory()
        {
            return _reviewDal.GetListWithCategory();
        }

        public void ReviewAdd(Review review)
        {
            throw new NotImplementedException();
        }

        public void ReviewDelete(Review review)
        {
            throw new NotImplementedException();
        }

        public void ReviewUpdate(Review review)
        {
            throw new NotImplementedException();
        }

        public List<Review> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Review> GetReviewListByCustomer(int id)
        {
            return _reviewDal.GetListAll(x => x.CustomerID == id);

        }
    }
}
