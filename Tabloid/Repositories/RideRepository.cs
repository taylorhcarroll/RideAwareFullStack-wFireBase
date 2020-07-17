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
    public class RideRepository
    {
        //saving an instance of our app db context
        private readonly ApplicationDbContext _context;
        public RideRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Ride GetRideById(int id)
        {
            return _context.Ride
                           .FirstOrDefault(c => c.Id == id);
        }
        public List<Ride> GetAllRides()
        {
            return _context.Ride
                           .ToList();
        }
        
        //for ride history
        public List<Ride> GetRidesCompletedByUser(int id)
        {
            return _context.Ride
                            .Where(r => r.UserId == id && r.Completed == true  )
                            .Include(r => r.User)
                            .Include(r => r.Car)
                            .Include(r => r.Passengers)
                                .ThenInclude(p => p.Student)
                            .ToList();
        }

        //shows all students that have been completed
        public List<Ride> GetRidesCompleted()
        {
            var currentTime = DateTime.Now.ToString("d");

            return _context.Ride
                            .Where(r => r.Completed == true && r.TimeStamp.ToString("d") == currentTime)
                            .Include(r => r.User)
                            .Include(r => r.Car)
                            .Include(r => r.Passengers)
                                .ThenInclude(p => p.Student)
                            .ToList();
        }

        //shows all students that need to be picked up

        public List<Ride> GetIncompleteRides()
        {
            var currentTime = DateTime.Now.ToString("d");

            return _context.Ride
                            .Where(r => r.Completed == false && r.TimeStamp.ToString("d") != currentTime)
                            .Include(r => r.User)
                            .Include(r => r.Car)
                            .Include(r => r.Passengers)
                                .ThenInclude(p => p.Student)
                            .ToList();
        }

        public void Add(Ride ride)
        {
            _context.Add(ride);
            _context.SaveChanges();
        }

        public void Update(Ride ride)
        {
            _context.Entry(ride).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var ride = GetRideById(id);
            _context.Ride.Remove(ride);
            _context.SaveChanges();
        }

    }
}
