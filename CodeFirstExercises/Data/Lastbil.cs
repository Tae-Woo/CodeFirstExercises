using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExercises.Data
{
    public class Lastbil
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public int LoadVolumeKvm { get; set; }
        public string RegNumber { get; set; }
    }
}
