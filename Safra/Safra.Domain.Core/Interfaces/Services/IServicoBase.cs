using System.Collections.Generic;

namespace Safra.Domain.Core.Interfaces.Services
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Upadte(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
