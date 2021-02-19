using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal

    {
        public void Add(Brand t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand t)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByBrandId(int BrandId)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand t)
        {
            throw new NotImplementedException();
        }
    }
}
