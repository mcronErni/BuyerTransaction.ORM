namespace ORMAct.Contract
{
    public class TransactionProductDTO
    {
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal PriceAtTransaction { get; set; }
        public decimal TotalPrice => Quantity * PriceAtTransaction;
    }
}
