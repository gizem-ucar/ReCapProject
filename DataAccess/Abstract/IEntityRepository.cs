using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);   //Linq kullandık. tek bir data getirmek istedik kullanırız.
        T GetById(int brandId);
        List<T> GetCarsByBrandId(int BrandId);
        List<T> GetCarsByColorId(int ColorId);
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
    }
}
