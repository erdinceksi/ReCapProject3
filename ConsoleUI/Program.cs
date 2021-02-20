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
            CarManager carManager = new CarManager(new EfCarDal());

            var carList = new List<Car> {
                new Car{BrandId = 1, ColorId = 1, ModelYear = 2017, DailyPrice = 185000, Description = "Toyota Corolla", Id = 1},
                new Car{BrandId = 2, ColorId = 1, ModelYear = 2016, DailyPrice = 750000, Description = "Mercedes C 180", Id = 2},
                new Car{BrandId = 3, ColorId = 2, ModelYear = 2019, DailyPrice = 805000, Description = "BMW 3.20i", Id = 3},
                new Car{BrandId = 4, ColorId = 4, ModelYear = 2016, DailyPrice = 530000, Description = "Jaguar XE 2.0D R-SPORT", Id = 4},
                new Car{BrandId = 5, ColorId = 5, ModelYear = 2006, DailyPrice = 600000, Description = "Honda S2000", Id = 5}
            };

            foreach (var car in carList)
            {
                carManager.Add(car);
            }

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Car Id: {0}, Brand Id: {1}, ColorId: {2}, DailyPrice: {3}, Description: {4}, ModelYear: {5}",
                    car.Id, car.BrandId, car.ColorId, car.DailyPrice, car.Description, car.ModelYear);
            }
        }
    }
}
