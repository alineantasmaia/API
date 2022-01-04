using Microsoft.EntityFrameworkCore;
using Safra.Domain.Core.Interfaces;


namespace Safra.Infra.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

    }
}
