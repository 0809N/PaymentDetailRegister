using PaymentDetailRegister.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PaymentDetailRegister.Models.Data
{
    public class PaymentDetailManager : IDataRepository<PaymentDetail>
    {
        readonly PaymentDetailContext _paymentDetailContext;
        public PaymentDetailManager(PaymentDetailContext context)
        {
            _paymentDetailContext = context;
        }
        public void Add(PaymentDetail entity)
        {
            _paymentDetailContext.PaymentDetails.Add(entity);
            _paymentDetailContext.SaveChanges();
        }

        public void Delete(PaymentDetail entity)
        {
            _paymentDetailContext.PaymentDetails.Remove(entity);
            _paymentDetailContext.SaveChanges();
        }

        public PaymentDetail get(int id)
        {
            return _paymentDetailContext.PaymentDetails
                .FirstOrDefault(e => e.PMId == id);
        }

        public IEnumerable<PaymentDetail> GetAll()
        {
            return _paymentDetailContext.PaymentDetails.ToList();
        }

        public void Update(PaymentDetail dbEntity, PaymentDetail entity)
        {
            dbEntity.CardOwnerName = entity.CardOwnerName;
            dbEntity.CardNumber = entity.CardNumber;
            dbEntity.ExpirationDate = entity.ExpirationDate;
            dbEntity.CVV = entity.CVV;

            _paymentDetailContext.SaveChanges();
        }
    }
}
