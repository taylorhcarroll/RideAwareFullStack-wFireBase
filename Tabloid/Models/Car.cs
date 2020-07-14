using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tabloid.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Year { get; set; }

        public string ImageLocation { get; set; }

    }
}