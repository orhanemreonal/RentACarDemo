using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                var gottenEntity = context.Set<TEntity>();
                return gottenEntity.FirstOrDefault(filter);
                //return context.Set<TEntity>().SingleOrDefault(filter); ---> SingleOrDefault: Birden fazla değer varsa hata basar.
                                                                              //Tek Değer varsa döndürür. Hiç değer yoksa default T Döndürür.
                //return context.Set<TEntity>().FirstOrDefault(filter);  ----> FirstOrDefault: Birden fazla değer varsa ilk değer yazdırılır.Kalanlar gözardı edilir.
                                                                              //Tek Değer varsa döndürür. Hiç değer yoksa default T Döndürür.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //if(filter == null)
                //{
                //   return context.Set<TEntity>().ToList();
                //}
                //else
                //{
                //   return context.Set<TEntity>().Where(filter).ToList();
                //}
                return filter == null ? context.Set<TEntity>().ToList() 
                                      : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
