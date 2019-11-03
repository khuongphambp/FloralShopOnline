using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Bill : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public User User { get; set; }
        public int Total { get; set; }
        public string Payment { get; set; }
        public string Note { get; set; }
        public DateTime CreateTime { get ; set; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get; set; }
        public ICollection<BillDetail> BillDetails { get; set; }
    }
}
