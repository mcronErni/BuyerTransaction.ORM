using System.ComponentModel.DataAnnotations;

namespace ORMAct.Model
{
    public class TransactionModel
    {
        public int TransactionId { get; set; }
        [Required]
        public required int BuyerId { get; set; }
        [Required]
        public required DateOnly TransactionDate { get; set; }
        [Required]
        public required string TransactionStatus { get; set; } // Completed OR Pending, Cancelled

        public required Buyer Buyer { get; set; }
        public ICollection<TransactionProduct> TransactionProducts { get; set; }
    }
}