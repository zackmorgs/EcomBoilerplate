using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Category {
    
        // Unique identifier for the product
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }
    
    public string Name { get; set; } = String.Empty;

    List<Product> Products { get; set; } = new List<Product>();

    // Computed URL property based on Name
    [NotMapped] // Indicates that this property is not mapped to a database column
    public string Url => "/category/" + Name.Replace(" ", "-").ToLower();
}