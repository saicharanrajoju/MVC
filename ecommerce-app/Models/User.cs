using System;
using System.Collections.Generic;

namespace ecommerce_app.Models
{
    public partial class User
    {
        public User()
        {
            Order = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
