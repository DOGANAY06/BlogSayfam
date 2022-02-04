using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T:class //entity nin karsılığı T  bu T classa ait bütün değerleri kullanacak
    {
        void Insert(T t); //T türünden t çağırdırk 
        void Delete(T t);
        void Update(T t);
        List<T> GetListAll();
        T GetByID(int id);
        List<T> GetListAll(Expression<Func<T, bool>> filter);
            //bloga göre listeleme yapabilmek için yazıyoruz
    }
}
