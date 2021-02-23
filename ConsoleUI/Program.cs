//using Business.Abstract;
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
            CarTest();
            //BrandTest();


            //foreach (var car in carManager.GetById(5))
            //{
            //    Console.WriteLine(car.Descrition);
            //}
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            
            var result = brandManager.GetAll();           
            
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data )
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName);
                }
            }
            
        }
    }
}
