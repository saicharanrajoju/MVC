using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal { get; set; }
        public int Id { get; set; }

        public virtual Product Prod { get; set; }
    }
}
