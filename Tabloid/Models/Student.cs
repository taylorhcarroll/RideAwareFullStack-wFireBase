using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        public string AvatarUrl { get; set; }

    }
}