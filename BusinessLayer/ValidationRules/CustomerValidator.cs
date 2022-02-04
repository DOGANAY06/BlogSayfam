using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidator :AbstractValidator<Customer>
    {//müşteri doğrılamaları 
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Yazar Adı Soyadı kısmı boş geçilemez");
            RuleFor(x => x.CustomerMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.CustomerPassword).NotEmpty().WithMessage("\nŞifre alanı boş gecilemez")
                    .MinimumLength(8).WithMessage("\nŞifre alanı 8 karakterden aşağı olamaz")
                    .MaximumLength(16).WithMessage("\nŞifre alanı 16 karakterden fazla olamaz")
                    .Matches(@"[A-Z]+").WithMessage("\nŞifre en az 1 adet büyük harf içermeli.")
                    .Matches(@"[a-z]+").WithMessage("\nŞifre en az 1 adet küçük harf içermeli.")
                    .Matches(@"[0-9]+").WithMessage("\nŞifre en az 1 adet rakam içermeli.");
            RuleFor(x => x.CustomerName).MinimumLength(2).WithMessage("Lüften en az 2 karakter girişi yapın");
            RuleFor(x => x.CustomerImage).MaximumLength(50).WithMessage("Lüften en fazla 50 karakterlik veri girişi yapın");
            
                    
        }
    }
}
