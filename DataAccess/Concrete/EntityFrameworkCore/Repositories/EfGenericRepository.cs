using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Contexts;
using Entities.Abstract;

namespace DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class , IEntity ,new()
    {
        
        public void Add(TEntity entity)
        {
            using var context = new BusinessTrackingContext();
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new BusinessTrackingContext();
            context.Set<TEntity>().Remove(entity);
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new BusinessTrackingContext();
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            using var context = new BusinessTrackingContext();
            return context.Set<TEntity>().Find(id);
        }

        public List<TEntity> GetAll()
        {
            using var context = new BusinessTrackingContext();
            return context.Set<TEntity>().ToList(); 
        }
    }
}
