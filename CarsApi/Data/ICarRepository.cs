using CarsApi.Models;
using System.Collections.Generic;

namespace CarsApi.Data
{
    public interface ICarRepository
    {
        Car GetById(int id);
        IEnumerable<Car> GetAll();
        void Add(Car entity);
        void Udate(Car entity);
        void Remove(int id);

    }
}
