using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            var addToCar = _carDal.Get(c=>c.Id == car.Id);
            if (addToCar == null)
            {
                if (car.Description.Length > 2)
                {
                    if (car.DailyPrice > 0)
                    {
                        _carDal.Add(car);
                        Console.WriteLine("Car {0} added to the list.", car.Description);
                    }
                    else
                    {
                        Console.WriteLine("DailyPrice : {0} must be greater than 0", car.DailyPrice);
                    }
                }
                else
                {
                    Console.WriteLine("CarDescription : {0} must be greater than 2", car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine("Car {0} already exists in the list.", car.Description);
            }
        }

        public void Delete(Car car)
        {
            if (_carDal.GetAll().Count == 0)
            {
                Console.WriteLine("\nNo car in the list.\n");
            }
            else
            {
                _carDal.Delete(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }
    }
}
