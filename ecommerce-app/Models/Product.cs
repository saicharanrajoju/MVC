using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public byte[] ProductImage { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
