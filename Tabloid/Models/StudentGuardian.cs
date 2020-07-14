using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class StudentGuardian
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int UserId { get; set; }
        public UserProfile User { get; set; }
        public bool PrimaryUser { get; set; }
        public bool Expire { get; set; }
        public DateTime ExpireDate { get; set; }

    }
}