using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class CarUser
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public bool PrimaryUser { get; set; }
        public bool Expire { get; set; }
        public DateTime ExpireDate { get; set; }

    }
}