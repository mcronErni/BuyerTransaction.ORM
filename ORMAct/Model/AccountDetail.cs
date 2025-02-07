using System.ComponentModel.DataAnnotations;

namespace ORMAct.Model
{
    public class AccountDetail
    {
        public int AccountDetailId { get; set; }
        [Required]
        public int BuyerId { get; set; }
        
        public required string AccountStatus { get; set; }
        public required DateOnly DateCreated { get; set; }

        public Buyer Buyer { get; set; }
    }
}
