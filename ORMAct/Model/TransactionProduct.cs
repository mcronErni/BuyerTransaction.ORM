using System.ComponentModel.DataAnnotations;

namespace ORMAct.Model
{
    public class TransactionProduct
    {
        [Required]
        public required int TransactionId { get; set; }
        [Required]
        public required int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PriceAtTransaction { get; set; }

        public required Transaction TransactionModel { get; set; }

        public required Product Product { get; set; }
    }
}