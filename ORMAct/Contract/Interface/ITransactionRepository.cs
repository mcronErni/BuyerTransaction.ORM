using ORMAct.Model;

namespace ORMAct.Contract.Interface
{
    public interface ITransactionRepository
    {
        public Task<TransactionModel> UpdateTransaction(int id, TransactionModel transaction);
        public Task<TransactionModel> CreateTransaction(TransactionModel transaction);
    }
}
