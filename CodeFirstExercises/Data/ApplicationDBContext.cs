using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExercises.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Bil> Cars { get; set; }
        public DbSet<Lastbil> Trucks { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
    }
}
