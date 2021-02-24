using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, ModelYear = "2019", CarDescription = "Süper bir araba"},
                new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 50, ModelYear = "2013", CarDescription = "Ayağını yerden keser"},
                new Car{CarId = 3, BrandId = 2, ColorId = 3, DailyPrice = 150, ModelYear = "2017", CarDescription = "Komforlu"},
                new Car{CarId = 4, BrandId = 1, ColorId = 2, DailyPrice = 90, ModelYear = "2015", CarDescription = "Biraz yakar ama iş görür"},
                new Car{CarId = 5, BrandId = 1, ColorId = 1, DailyPrice = 130, ModelYear = "2016", CarDescription = "Fena Değil"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
