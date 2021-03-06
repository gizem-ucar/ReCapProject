﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetCarDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                using (CarRentalContext Context = new CarRentalContext())
                {

                    var result = from r in filter == null ? context.Rentals : context.Rentals.Where(filter)
                                 join c in context.Cars
                                 on r.CarId equals c.CarId
                                 join cst in context.Customers
                                 on r.CustomerId equals cst.CustomerId
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join u in context.Users
                                 on cst.UserId equals u.Id
                                 select new RentalDetailDto
                                 {
                                     RentalId = r.RentalId,
                                     CarName = b.BrandName,
                                     CompanyName = cst.CompanyName,
                                     UserName = u.FirstName + " " + u.LastName,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate


                                 };
                    return result.ToList();

                }
            }
        }
    }
}
