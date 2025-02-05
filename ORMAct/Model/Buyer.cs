using System.ComponentModel.DataAnnotations;

namespace ORMAct.Model
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        public string? MobileNo { get; set; }
        [Required]
        public required string BuyerStatus { get; set; } // Active, Deleted, Deactivated, Banned

        public ICollection<Transaction>? Transactions { get; set; }

    }
}
