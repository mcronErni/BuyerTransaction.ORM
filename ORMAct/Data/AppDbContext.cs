using Microsoft.EntityFrameworkCore;
using ORMAct.Model;

namespace ORMAct.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TransactionModel> Transactions { get; set; }
        public DbSet<TransactionProduct> TransactionProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionProduct>()
                .HasKey(tp => new {tp.TransactionId, tp.ProductId});
            base.OnModelCreating(modelBuilder);
        }
    }
}
