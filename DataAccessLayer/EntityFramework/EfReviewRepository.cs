using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfReviewRepository : GenericRepository<Review>, IReviewDal
    {
        public List<Review> GetListWithCategory()
        {
            using (var c = new Context())
            {
                return c.Reviews.Include(x => x.Category).ToList();
                //category tablosunu dahil ettik ona ait verileri getirecek
            }
           
        }
    }
}
