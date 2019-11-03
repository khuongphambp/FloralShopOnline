using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Product : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public TypeProduct TypeProduct { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int PromotionPrice { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get; set ; }
        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
