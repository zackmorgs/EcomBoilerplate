using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcomServer.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public required User User { get; set; }

        public int ProductId { get; set; }

        public string Title { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;
    }
}