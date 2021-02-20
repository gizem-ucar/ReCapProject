using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();



            //foreach (var car in carManager.GetById(5))
            //{
            //    Console.WriteLine(car.Descrition);
            //}
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager();
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(3))
            {
                Console.WriteLine(car.BrandName);
            }
        }
    }
}
