using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2000, DailyPrice = 400.000, Description = "2013 BMW X3 3.0 dizel SUV"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, ModelYear = 2000, DailyPrice = 1.500000, Description = "2015 Mercedes GLA 4.0 dizel SUV"},
                new Car{Id = 3, BrandId = 2, ColorId = 3, ModelYear = 2000, DailyPrice = 400.000, Description = "2008 Opel Astra 1.6 benzin"},
                new Car{Id = 4, BrandId = 2, ColorId = 4, ModelYear = 2000, DailyPrice = 500.000, Description = "2014 Toyota Auris 1.6 dizel"},
                new Car{Id = 5, BrandId = 2, ColorId = 4, ModelYear = 2000, DailyPrice = 1.400000, Description = "2017 Renault Megane 1.6 dizel"},

            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
           _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear = car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllByCategorty(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.Id == car.Id).ToList();
        }
    }
}
