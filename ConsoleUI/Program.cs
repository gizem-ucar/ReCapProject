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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(3))
            {
                Console.WriteLine(car.BrandName);
            }

            

            //foreach (var car in carManager.GetById(5))
            //{
            //    Console.WriteLine(car.Descrition);
            //}
        }
    }
}
