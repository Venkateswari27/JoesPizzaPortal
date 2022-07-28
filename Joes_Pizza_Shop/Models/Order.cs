using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Joes_Pizza_Shop.Models
{
    public partial class Order
    {
      
        public Order()
        {
            this.CustomerOrderTables = new HashSet<CustomerOrderTable>();
        }

        [Key]
        public int OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<double> TotalAmount { get; set; }

       
        public virtual ICollection<CustomerOrderTable> CustomerOrderTables { get; set; }
    }
}
