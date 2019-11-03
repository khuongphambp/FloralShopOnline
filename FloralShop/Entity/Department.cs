using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FloralShop.Entity
{
    public class Department : Base
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreateTime { get; set ; }
        public DateTime UpdateTime { get ; set ; }
        public bool IsDelete { get; set ; }

        public ICollection<TypeProduct> TypeProducts { get; set; }
    }
}
