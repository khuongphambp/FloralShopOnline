using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Contact : Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Messenger { get; set; }
        public DateTime CreateTime { get ; set; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get ; set ; }
    }
}
