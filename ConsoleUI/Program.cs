using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Description: {0}, BrandName: {1}, ColorName: {2}, DailyPrice: {3}",
                    car.Description, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }
    }
}
