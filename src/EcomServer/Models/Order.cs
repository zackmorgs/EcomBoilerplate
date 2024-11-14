
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Order {
            // Unique identifier for the product
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set;}
    
    // Date when the order was placed
    public DateTime DateOrdered { get; set; } = DateTime.UtcNow;
    
    // Date when the order was delivered
    public DateTime DateDelivered { get; set; } = DateTime.UtcNow;

    // Total price of the order
    public double TotalPrice { get; set; } = 0.0;

    public List<Product> OrderItems { get; set; } = new List<Product>();

    public int UserId { get; set; }
}