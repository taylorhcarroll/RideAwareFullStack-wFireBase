using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public DateTime TimeStamp { get; set; }
        public DateTime EditTimeStamp { get; set; }
        public bool Completed { get; set; }
        public int LocationId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public List<StudentRide> Passengers { get; set; }


    }
}