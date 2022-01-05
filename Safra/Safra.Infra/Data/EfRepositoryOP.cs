using Safra.Domain.Core.Interfaces.Repositories;
using Safra.Domain.Entities;

namespace Safra.Infra.Data
{
    public class EfRepositoryOP : EfRepositoryBase<Operacoes>,IRepositoryOp
    {
        private readonly Context _context;

        public EfRepositoryOP(Context context):base(context)
        {
            _context = context;
        }

    }
}
