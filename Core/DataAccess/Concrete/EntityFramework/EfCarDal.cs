using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = c.DailyPrice,
                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
        public CarDetailDto GetCarDetails(int carId)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars.Where(c => c.CarId == carId)
                             join clr in context.Colors on c.ColorId equals clr.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId

                             select new CarDetailDto()
                             {
                                 BrandName = b.BrandName,
                                 ColorName = clr.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 CarId = c.CarId
                             };

                return result.SingleOrDefault();
            }
        }
    }
}
