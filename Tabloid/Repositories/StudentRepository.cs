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
    public class StudentRepository
    {
        //saving an instance of our app db context
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }



        public Student GetStudentById(int id)
        {
            return _context.Student
                           .FirstOrDefault(c => c.StudentId == id);
        }
        public List<Student> GetAllStudents()
        {
            return _context.Student
                           .ToList();
        }
        public List<Student> GetStudentsByUser(int id)
        {
            return _context.StudentGuardian
                            .Where(cu => cu.UserId == id && cu.Expire == false)
                              .Include(cu => cu.Student)
                              .Select(cu => cu.Student)
                              .ToList();
        }

        public void Add(Student car)
        {
            _context.Add(car);
            _context.SaveChanges();
        }

        public void Update(Student car)
        {
            _context.Entry(car).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var car = GetStudentById(id);
            _context.Student.Remove(car);
            _context.SaveChanges();
        }

    }
}
