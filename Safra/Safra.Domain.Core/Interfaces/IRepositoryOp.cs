using System.Collections.Generic;
using Safra.Domain.Entities;
using System.Threading.Tasks;

namespace Safra.Domain.Core.Interfaces
{
    public interface IRepositoryOp
    {
        Task<Operacoes> Add(Operacoes obj);
        Task<Operacoes> Update(Operacoes obj);        
        Task<Operacoes> Delete(Operacoes obj);
        public IEnumerable<Operacoes> GetAll() { return null; }
        public Operacoes GetById(int id);

        /*void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        IEnumerable<T> GetAll() { return null; }
        T GetById(int id); */
    }
}
