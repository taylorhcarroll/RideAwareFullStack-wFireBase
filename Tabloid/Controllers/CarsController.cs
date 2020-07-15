//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Tabloid.Data;
//using Tabloid.Models;
//using System.Security.Claims;
//using Tabloid.Repositories;

//namespace Tabloid.Controllers
//{
//    [Authorize]
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CarsController : ControllerBase
//    {
//        //private readonly ApplicationDbContext _context;
//        private readonly UserProfileRepository _userProfileRepository;
//        private readonly CarRepository _carRepository;
        

//        public CarsController(ApplicationDbContext context)
//        {
//            _userProfileRepository = new UserProfileRepository(context);
//            _carRepository = new CarRepository(context);
//        }

//        // GET: api/Cars
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<Car>>> GetCar()
//        {
//            return await _context.Car.ToListAsync();
//        }

//        // GET: api/Cars/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Car>> GetCar(int id)
//        {
//            var car = await _context.Car.FindAsync(id);

//            if (car == null)
//            {
//                return NotFound();
//            }

//            return car;
//        }

//        // PUT: api/Cars/5
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutCar(int id, Car car)
//        {
//            if (id != car.CarId)
//            {
//                return BadRequest();
//            }

//            _context.Entry(car).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!CarExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return NoContent();
//        }

//        // POST: api/Cars
//        // To protect from overposting attacks, enable the specific properties you want to bind to, for
//        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
//        [HttpPost]
//        public async Task<ActionResult<Car>> PostCar(Car car)
//        {
//            _context.Car.Add(car);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction("GetCar", new { id = car.CarId }, car);
//        }

//        // DELETE: api/Cars/5
//        [HttpDelete("{id}")]
//        public async Task<ActionResult<Car>> DeleteCar(int id)
//        {
//            var car = await _context.Car.FindAsync(id);
//            if (car == null)
//            {
//                return NotFound();
//            }

//            _context.Car.Remove(car);
//            await _context.SaveChangesAsync();

//            return car;
//        }

//        private bool CarExists(int id)
//        {
//            return _context.Car.Any(e => e.CarId == id);
//        }
//        private UserProfile GetCurrentUserProfile()
//        {
//            var firebaseUserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
//            return _userProfileRepository.GetByFirebaseUserId(firebaseUserId);
//        }
//    }
//}
