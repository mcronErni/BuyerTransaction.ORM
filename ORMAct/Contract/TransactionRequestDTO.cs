namespace ORMAct.Contract
{
    public class TransactionRequestDTO
    {
        public int BuyerId { get; set; }
        public ICollection<ProductRequest> Product { get; set; }
    }
}
