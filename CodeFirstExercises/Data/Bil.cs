using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExercises.Data
{
    public class Bil
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string RegNumber { get; set; }
        public bool HasRadio { get; set; }
    }
}
