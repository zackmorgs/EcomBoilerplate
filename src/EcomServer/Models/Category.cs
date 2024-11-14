using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category {
    
        // Unique identifier for the product
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    int Id { get; set; }
    
    string Name { get; set; } = String.Empty;

    List<Product> Products { get; set; } = new List<Product>();

}