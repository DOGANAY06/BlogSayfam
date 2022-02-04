using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {//tabloları veritabanına bağlamamızı sağlar 
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        { //tanımlamış olduğumuz Database oluşturucu sınıfı
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=CoreBlogDb;integrated security=true;");
            //connection string 
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }


    }
}
