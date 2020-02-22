using Microsoft.EntityFrameworkCore;

namespace PaymentDetailRegister.Models
{
    public class PaymentDetailContext :DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetail>().HasData(new PaymentDetail
            {
                PMId = 1,
                CardOwnerName = "Vy Vo",
                CardNumber = "9876543210123456",
                ExpirationDate = "09/09",
                CVV = "321"

            }, new PaymentDetail
            {
                PMId = 2,
                CardOwnerName = "Michel Core",
                CardNumber = "9876543210654321",
                ExpirationDate = "08/08",
                CVV = "333"
            });
        }
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
