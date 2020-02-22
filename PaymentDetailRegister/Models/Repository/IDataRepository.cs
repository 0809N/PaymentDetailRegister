using System.Collections.Generic;

namespace PaymentDetailRegister.Models.Repository
{
    interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
    }
}
