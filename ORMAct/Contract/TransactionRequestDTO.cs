namespace ORMAct.Contract
{
    public class TransactionRequestDTO
    {
        public int BuyerId { get; set; }
        public ICollection<ProductRequestDTO>? Product { get; set; }
    }
}
