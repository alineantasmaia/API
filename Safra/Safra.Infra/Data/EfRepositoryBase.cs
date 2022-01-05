using System;
using System.Collections.Generic;
using System.Linq;
using Safra.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Safra.Infra.Data
{
    public class EfRepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly Context _context;
        
        public EfRepositoryBase(Context context)
        {
            _context = context;
        }
        public void Add(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        public void Delete(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new(ex.Message);
            }
        }
    }
}
