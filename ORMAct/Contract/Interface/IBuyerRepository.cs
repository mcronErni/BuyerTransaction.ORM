using ORMAct.Model;

namespace ORMAct.Contract.Interface
{
    public interface IBuyerRepository
    {
        public Task<ICollection<Buyer>> Get();
        public Task<Buyer?> GetBuyerbyId(int id);
        public Task<Buyer?> CreateBuyer(Buyer buyer);
        public Task<Buyer?> UpdateBuyer(int id, Buyer buyer);
        public Task<Buyer?> DeleteBuyer(int id);
    }
}
