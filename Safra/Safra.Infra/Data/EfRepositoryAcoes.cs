using Safra.Domain.Core.Interfaces.Repositories;
using Safra.Domain.Entities;

namespace Safra.Infra.Data
{
    public class EfRepositoryAcoes:EfRepositoryBase<Acoes>,IRepositoryAcoes
    {
        private readonly Context _context;
        public EfRepositoryAcoes(Context context):base(context)
        {
            _context = context;
        }

    }
}
