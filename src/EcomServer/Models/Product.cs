using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    // Unique identifier for the product
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    // Name of the product
    [Required]
    [MaxLength(200)]
    public string Name { get; set; } = string.Empty;

    // Description of the product
    [MaxLength(1000)]
    public string Description { get; set; } = string.Empty;

    // Price of the product
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }

    // Quantity available in stock
    [Required]
    public int StockQuantity { get; set; }

    // URL or path to the product image
    [MaxLength(500)]
    public string ImageUrl { get; set; } = string.Empty;

    public required Category Category {get; set;}

    // Date when the product was added
    [Required]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public List<Review> Reviews { get; set; } = new List<Review>();
}
