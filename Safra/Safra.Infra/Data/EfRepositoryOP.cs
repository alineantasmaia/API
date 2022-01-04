using System;
using System.Threading.Tasks;
using Safra.Domain.Core.Interfaces;
using Safra.Domain.Entities;

namespace Safra.Infra.Data
{
    public class EfRepositoryOP : IRepositoryOp
    {
        private readonly Context _context;

        public EfRepositoryOP()
        {

        }

        public EfRepositoryOP(Context context)
        {
            _context = context;
        }

        public Task<Operacoes> Add(Operacoes obj)
        {
            throw new NotImplementedException();
        }

        public Task<Operacoes> Update(Operacoes obj)
        {
            throw new NotImplementedException();
        }

        public Task<Operacoes> Delete(Operacoes obj)
        {
            throw new NotImplementedException();
        }

        Operacoes IRepositoryOp.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
