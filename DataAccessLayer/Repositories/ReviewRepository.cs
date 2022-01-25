using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ReviewRepository : IReviewDal
    {
        public void AddReview(Review review)
        {
            using var c = new Context();
            c.Add(review);
            c.SaveChanges();
        }

        public void DeleteReview(Review review)
        {
            using var c = new Context();
            c.Remove(review);
            c.SaveChanges();
        }

        public Review GetById(int id)
        {
            using var c = new Context();
            return c.Reviews.Find(id);
        }

        public List<Review> ListAllReview()
        {
            using var c = new Context();
            return c.Reviews.ToList();
        }

        public void UpdateReviewy(Review review)
        {
            using var c = new Context();
            c.Update(review);
            c.SaveChanges();
        }

        Category IReviewDal.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
