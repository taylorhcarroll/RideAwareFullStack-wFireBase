using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tabloid.Data;
using Tabloid.Models;

namespace Tabloid.Repositories
{
    //keeping repository to do dependency injection, will register repositories with DI container
    //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-3.1
    public class CarRepository
    {
        //saving an instance of our app db context
        private readonly ApplicationDbContext _context;
        public CarRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public Car GetCarById(int id)
        {
            return _context.Car
                           .FirstOrDefault(c => c.CarId == id);
        }
        public List<Car> GetAllCars()
        {
            return _context.Car
                           .ToList();
        }
        public List<Car> GetCarsByUser(int id)
        {
            return _context.CarUser
                            .Where(cu => cu.UserId == id && cu.Expire == false)
                              .Include(cu => cu.Car)
                              .Select(cu => cu.Car)
                              .ToList();
        }

        public void Add(Car car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }

        public void Update(Car car)
        {
            _context.Entry(car).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = GetCarById(id);
            _context.Car.Remove(car);
            _context.SaveChanges();
        }

    }
}
