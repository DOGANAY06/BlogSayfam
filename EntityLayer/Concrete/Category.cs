using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        //erişim belirleyici türü değişkentürü isim 
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Review> Review { get; set; }

    }
}
