using CarsWeb.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace CarsWeb.Services
{
    public class CarService : ICarService
    {
        private static string _baseUrl;

        public CarService()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            _baseUrl = builder.GetSection("ApiSettings:baseUrl").Value;
        }

        public async Task<List<Car>> GetAll()
        {
            List<Car> cars = new List<Car>();
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            var response = await client.GetAsync("");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var resul = JsonSerializer.Deserialize<List<Car>>(jsonResponse);

                cars = resul;
            }

            return cars;
            
        }

        public Task<bool> Create(Car car)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new System.NotImplementedException();
        }

    

        public Task<Car> GetCar(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Car car)
        {
            throw new System.NotImplementedException();
        }
    }
}
