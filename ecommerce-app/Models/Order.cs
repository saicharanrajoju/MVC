using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public partial class Order
    {
        public Order()
        {
            Transaction = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int PlacedBy { get; set; }

        public virtual User PlacedByNavigation { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
    }
}
