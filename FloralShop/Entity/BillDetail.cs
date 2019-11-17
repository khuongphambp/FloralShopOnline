using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class BillDetail : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Bill")]
        public int BillID { get; set; }
        public Bill Bill { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime CreateTime { get ; set  ; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get; set; }
    }
}
