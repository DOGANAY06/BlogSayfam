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
    public class CategoryRepository : ICategoryDal
    {//implement ettik altta ekledik imzaların içini doldurucaza 
        Context c = new Context(); 
        public void AddCategory(Category category)
        {
            c.Add(category); //category den gelen değeri ekle 
            c.SaveChanges(); //değişiklikleri kaydet
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id); //id göre getir önce bul sonra getir
        }

        public List<Category> ListAllCategory()
        {
            return c.Categories.ToList(); // CATEGORY göre listele 
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
