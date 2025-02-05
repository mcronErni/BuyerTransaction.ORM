using ORMAct.Model;

namespace ORMAct.Contract
{
    public class TransactionDTO
    {
        public int TransactionId { get; set; }
        public DateOnly TransactionDate { get; set; }
        public required string BuyerName { get; set; }
        public required ICollection<TransactionProductDTO> Product{ get; set; }
        public decimal TotalPrice => Product.Sum(p => p.TotalPrice);
    }
}
