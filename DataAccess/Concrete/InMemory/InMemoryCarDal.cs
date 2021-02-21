using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Conrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        public InMemoryCarDal()
        {
            cars = new List<Car>
            {
                new Car{ CarId = 1,BrandId = 1,ColorId = 1,DailyPrice = 150,ModelYear = 2015,Description = "Audi"},
                new Car{ CarId = 2,BrandId = 3,ColorId = 2,DailyPrice = 100,ModelYear = 2011,Description = "Fiat" },
                new Car{ CarId = 3,BrandId = 5,ColorId = 4,DailyPrice = 200,ModelYear = 2018,Description = "BMW"},
                new Car{ CarId = 4,BrandId = 2,ColorId = 3,DailyPrice = 180,ModelYear = 2016,Description = "Hyundai"}          
             };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = cars.SingleOrDefault(c => car.CarId == c.CarId);
            cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return cars;
        }

        public List<Car> GetById(int carId)
        {
            return cars.Where(car => carId == car.CarId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
