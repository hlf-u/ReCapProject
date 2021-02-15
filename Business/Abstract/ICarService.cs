﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllById(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        List<CarDetailDto> GetCarDetails();

    }
}
