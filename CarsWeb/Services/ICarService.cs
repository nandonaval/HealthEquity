using CarsWeb.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarsWeb.Services
{
    public interface ICarService
    {
        Task<List<Car>> GetAll();
        Task<Car> GetCar(int id);
        Task<bool> Create(Car car);
        Task<bool> Update(Car car);   
        Task<bool> Delete(int id);
    }
}
