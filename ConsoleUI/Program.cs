using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
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
