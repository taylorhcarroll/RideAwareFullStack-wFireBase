//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Tabloid.Data;
//using Tabloid.Models;

//namespace Tabloid.Repositories
//{
//    public class CarRepository
//    {
//        //saving an instance of our app db context
//        private readonly ApplicationDbContext _context;
//        public CarRepository(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public Car GetCarById(int id)
//        {
//            return _context.Car
//                           .Include(c => c.Post)
//                           .FirstOrDefault(c => c.Id == id);
//        }
//        public List<Car> GetAllCars()
//        {
//            return _context.Car
//                           .Include(c => c.Post)
//                           .ToList();
//        }
//        public List<Car> GetCarsByUser(string id)
//        {
//            return _context.Car
//                            .Include(c => c.CarId)
//                            //.Include(c => c.UserProfile)
//                            .Where(c => c.UserId == id && c.Expire = false)
//                            .ToList();
//        }

//        public void Add(Car comment)
//        {
//            _context.Add(comment);
//            _context.SaveChanges();
//        }

//        public void Update(Car comment)
//        {
//            _context.Entry(comment).State = EntityState.Modified;
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var comment = GetCarById(id);
//            _context.Car.Remove(comment);
//            _context.SaveChanges();
//        }

//    }
//}
