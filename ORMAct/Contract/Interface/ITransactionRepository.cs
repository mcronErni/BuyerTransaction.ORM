using ORMAct.Model;

namespace ORMAct.Contract.Interface
{
    public interface ITransactionRepository
    {
        public Task<Transaction> UpdateTransaction(int id, Transaction transaction);
        public Task<Transaction> CreateTransaction(Transaction transaction);
    }
}
