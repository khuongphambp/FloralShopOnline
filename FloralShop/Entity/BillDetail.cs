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
        public int IDProduct { get; set; }
        public Product Product { get; set; }
        public int IDBill { get; set; }
        public Bill Bill { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime CreateTime { get ; set  ; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get; set; }
    }
}
