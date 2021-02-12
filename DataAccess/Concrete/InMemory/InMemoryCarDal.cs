using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1, BrandName="BMW", BrandId=1, ColorId=1, DailyPrice=1000, ModelYear=2000},
                new Car{CarId=2, BrandName="Jaguar", BrandId=2, ColorId=3, DailyPrice=6000, ModelYear=2020},
                new Car{CarId=3, BrandName="Mini cooper", BrandId=2, ColorId=4, DailyPrice=8700, ModelYear=2010},
                new Car{CarId=4, BrandName="Mercedes", BrandId=2, ColorId=16, DailyPrice=9000, ModelYear=2008},
                new Car{CarId=5, BrandName="Anadol", BrandId=2, ColorId=9, DailyPrice=12000, ModelYear=2009}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.BrandName = car.BrandName;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;

        }
        public List<Car> GetAll()
        {
            return _cars;
            
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(p => p.BrandId == brandId).ToList();   
        }
    }
}
