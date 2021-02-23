using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity: class, IEntity, new()
        where TContext: DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())                      //using içinde yazmamızın sebebi: context pahalı ve using ile çöp toplayıcıyı bekleme 
                                                                           //ve bittiği an  dispose et.   dispose: bellekten uçur demek.
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();                                     //Bunu yazınca ekliyor.
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

        public TEntity Get(Expression<Func<TEntity, bool>> filter)   //tek data getirecek
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null                              //filter null ise 
                    ? context.Set<TEntity>().ToList()                  //evetse bu
                    : context.Set<TEntity>().Where(filter).ToList();   //hayırsa
            }
        }

        //public List<TEntity> GetById(int brandId)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Set<TEntity>.SingleOrDefault(c => c.BrandId == brandId);   //(filter) idi
        //    }
        //}

        //public TEntity GetById(int brandId)
        //{
        //    using (TContext context = new TContext())
        //    {
        //        return context.Cars.SingleOrDefault(c => c.BrandId == brandId);   //(filter) idi
        //    }
        //}


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
