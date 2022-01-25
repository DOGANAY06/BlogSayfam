using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }

        public string ReviewThumbNailImage { get; set; }
        public string ReviewImage { get; set; }
        public string Product { get; set; }

        public DateTime ReviewCreateDate { get; set; }

        public bool ReviewStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; } //HER ELEŞTRİNİN KENDİ KATEGORİSİ VAR
        public List<Comment> Comments { get; set; }
    }
}
