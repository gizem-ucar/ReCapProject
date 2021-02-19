using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Color = Entities.Concrete.Color;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())      //using içinde yazmamızın sebebi: context pahalı ve using ile çöp toplayıcıyı bekleme 
                                                                           //ve bittiği an  dispose et.   dispose: bellekten uçur demek.
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)   
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null                               
                    ? context.Set<Color>().ToList()                  
                    : context.Set<Color>().Where(filter).ToList();   
            }
        }

        public Color GetById(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByBrandId(int BrandId)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
