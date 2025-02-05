using System.ComponentModel.DataAnnotations;

namespace ORMAct.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public required string ProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public required string ProductStatus { get; set; } // Deleted, Active

        public ICollection<TransactionProduct>? TransactionProduct { get; set; }

    }
}
