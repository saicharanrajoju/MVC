using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }
    }
}
