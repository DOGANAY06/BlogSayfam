using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSayfam.Controllers
{
    public class RegisterController : Controller
    {
        CustomerManager cm = new CustomerManager(new EfCustomerRepository());
        [HttpGet] //attribute veriyi getirir  
        //ekleme yapmak için metotların isimleri aynı olmak zorunda 
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //veriyi alır veri tabanına götürür kaydet butonuna basınca 
        public IActionResult Index(Customer c)
        { //htpp post parametre bekler 1 adet kullanıcı gönderdim
            //validatonreules doğru mu değil mi kontrol edicez
            CustomerValidator cv = new CustomerValidator();
            ValidationResult results = cv.Validate(c);
            //parametreden gelen değerleri validation da kontrol et bakalım doğru mu giriş 
            if (results.IsValid)
            {//sonuçlar geçerliyse
                c.CustomerStatus = true;
                //kullanıcınn durumu true
                cm.CustomerAdd(c);
                return RedirectToAction("Index", "Review");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    //hatayı veren özelliğin ismi ve hatanın kendisini döndür
                }

            }
            return View();
        }
    }
}
