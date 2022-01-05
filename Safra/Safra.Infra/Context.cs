using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Safra.Domain.Entities;

namespace Safra.Infra
{
    public partial class Context:DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Operacoes> Operacoes { get; set; }
        public DbSet<Acoes> Acoes { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("OpDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("OpDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("OpDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acoes>()
                .HasData(
                    new Acoes { Id = 1, RazaoSocial = "Grupo Alcoa S.A", Valor = 545},
                    new Acoes { Id=2,RazaoSocial="Rendas Reunidas S.A",Valor=100}
                );


            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
