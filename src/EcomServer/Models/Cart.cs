using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomServer.Models
{
    public class Cart
    {
        // Unique identifier for the product
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required int UserId { get; set; }

        // this works great for an empty cart.
        public List<Product> Products { get; set; } = new List<Product>();

    }
}