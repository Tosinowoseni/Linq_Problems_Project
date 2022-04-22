using System;
using System.Collections.Generic;

namespace DatabaseFirstLINQ.Models
{
    public partial class User
    {
        public User()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
            Roles = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegistrationDate { get; set; }

        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
