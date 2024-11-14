using Microsoft.AspNetCore.Identity;
using System;
namespace EcomServer.Models
{
    public class User : IdentityUser
    {
        // Indicates whether the user has admin privileges
        public bool IsAdmin { get; set; } = false;

        public List<Product> ProductsInCart { get; set; } = new List<Product>();

        public List<Review> Reviews { get; set; } = new List<Review>();

        // Date when the user registered
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public List<Order> Orders { get; set; } = new List<Order>();

        public int CartId { get; set; }

        // Method to assign admin privileges
        public void GrantAdminPrivileges()
        {
            IsAdmin = true;
        }

        // Method to revoke admin privileges
        public void RevokeAdminPrivileges()
        {
            IsAdmin = false;
        }

        // Optional: Method to check if the user is an admin
        public bool CheckIfAdmin()
        {
            return IsAdmin;
        }
    }
}