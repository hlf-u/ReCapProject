﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2008,DailyPrice=200,Description="Opel Combo 1.3 CDTi City Beyaz"},
                new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2017,DailyPrice=300,Description="Peugeot 307 1.4 HDi Mavi"},
                new Car{Id=3,BrandId=3,ColorId=1,ModelYear=2015,DailyPrice=300,Description="Ford Fiesta 1.0 GTDi Beyaz"},
                new Car{Id=4,BrandId=4,ColorId=3,ModelYear=2020,DailyPrice=350,Description="Renault Megane 1.5 dCi Siyah"},
                new Car{Id=5,BrandId=1,ColorId=2,ModelYear=2019,DailyPrice=370,Description="Opel Insignia 1.6 CDTi Mavi"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
