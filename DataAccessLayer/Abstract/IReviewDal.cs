using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReviewDal:IGenericDal<Review>
    {//tekrar tekrar metotları yazmaktan kurtulduk direk genericden referans aldık 
        //gelen görüşlere özel 
        List<Review> GetListWithCategory(); //category ile birlikte blogları görüşleri listele bu generic yapıya ek ilgili entity ait 



    }
}
