using ORMAct.Contract.Interface;
using ORMAct.Data;
using ORMAct.Model;

namespace ORMAct.Contract.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly AppDbContext _context;

        public BuyerRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task<Buyer> CreateBuyer(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer?> DeleteBuyer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Buyer>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Buyer?> GetBuyerbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer?> UpdateBuyer(int id, Buyer buyer)
        {
            throw new NotImplementedException();
        }
    }
}
