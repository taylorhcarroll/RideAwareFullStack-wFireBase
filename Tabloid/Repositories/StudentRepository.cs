//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Tabloid.Data;
//using Tabloid.Models;

//namespace Tabloid.Repositories
//{
//    public class StudentRepository
//    {
//        //saving an instance of our app db context
//        private readonly ApplicationDbContext _context;
//        public StudentRepository(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public Student GetStudentById(int id)
//        {
//            return _context.Student
//                           .Include(c => c.Post)
//                           .FirstOrDefault(c => c.Id == id);
//        }
//        public List<Student> GetAllStudents()
//        {
//            return _context.Student
//                           .Include(c => c.Post)
//                           .ToList();
//        }
//        public List<Student> GetStudentsByPostId(int id)
//        {
//            return _context.Student
//                            .Include(c => c.UserProfile)
//                            .Include(c => c.Post)
//                            .OrderByDescending(c => c.CreateDateTime)
//                            .Where(c => c.PostId == id)
//                            .ToList();
//        }

//        public void Add(Student comment)
//        {
//            _context.Add(comment);
//            _context.SaveChanges();
//        }

//        public void Update(Student comment)
//        {
//            _context.Entry(comment).State = EntityState.Modified;
//            _context.SaveChanges();
//        }

//        public void Delete(int id)
//        {
//            var comment = GetStudentById(id);
//            _context.Student.Remove(comment);
//            _context.SaveChanges();
//        }

//    }
//}
