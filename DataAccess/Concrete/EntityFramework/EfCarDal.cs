using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())      //using içinde yazmamızın sebebi: context pahalı ve using ile çöp toplayıcıyı bekleme 
                                                                           //ve bittiği an  dispose et.   dispose: bellekten uçur demek.
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();                                     //Bunu yazınca ekliyor.
            }
        }

        public void Delete(Car entity)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter )   //tek data getirecek
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return filter == null                              //filter null ise 
                    ? context.Set<Car>().ToList()                  //evetse bu
                    : context.Set<Car>().Where(filter).ToList();   //hayırsa
            }
        }

        public Car GetById(int brandId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.Cars.SingleOrDefault(c => c.BrandId == brandId);   //(filter) idi
            }
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
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
