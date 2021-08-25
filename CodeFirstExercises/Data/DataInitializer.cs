using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstExercises.Data
{
    public class DataInitializer
    {
        
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();
            
            SeedManufacturer(dbContext);
            SeedCars(dbContext);
            SeedLastbil(dbContext);
            FixManufacturersForBilAndLastbil(dbContext);
            dbContext.SaveChanges();
        }
        private static void FixManufacturersForBilAndLastbil(ApplicationDbContext dbContext)
        {
            var volvo = dbContext.Manufacturers.First(r => r.Name == "Volvo");
            var audi = dbContext.Manufacturers.First(r => r.Name == "Audi");
            var bmw = dbContext.Manufacturers.First(r => r.Name == "BMW");
            var volkswagen = dbContext.Manufacturers.First(r => r.Name == "Volkswagen");
            var saab = dbContext.Manufacturers.First(r => r.Name == "Saab");
            var scania = dbContext.Manufacturers.First(r => r.Name == "Scania");
            var mercedes = dbContext.Manufacturers.First(r => r.Name == "Mercedes");

            dbContext.Cars.First(r => r.RegNumber == "BBB111").Manufacturer = volvo;
            dbContext.Cars.First(r => r.RegNumber == "BDC234").Manufacturer = audi;
            dbContext.Cars.First(r => r.RegNumber == "CDE345").Manufacturer = bmw;
            dbContext.Cars.First(r => r.RegNumber == "DEF456").Manufacturer = volkswagen;
            dbContext.Cars.First(r => r.RegNumber == "EFG567").Manufacturer = saab;

            dbContext.Trucks.First(r => r.RegNumber == "HEJ123").Manufacturer = volvo;
            dbContext.Trucks.First(r => r.RegNumber == "FGH678").Manufacturer = scania;
            dbContext.Trucks.First(r => r.RegNumber == "GHI789").Manufacturer = mercedes;

            dbContext.SaveChanges();
        }
        private static void SeedManufacturer(ApplicationDbContext dbContext)
        {
            if (!dbContext.Manufacturers.Any(r=>r.Name == "Volvo"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Volvo"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "Audi"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Audi"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "BMW"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "BMW"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "Wolksvagen"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Volkswagen"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "Saab"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Saab"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "Scania"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Scania"
                });
            }
            if (!dbContext.Manufacturers.Any(r => r.Name == "Mercedes"))
            {
                dbContext.Manufacturers.Add(new Manufacturer
                {
                    Name = "Mercedes"
                });
            }
            dbContext.SaveChanges();
        }
        private static void SeedCars(ApplicationDbContext dbContext)
        {
            var volvo = dbContext.Manufacturers.First(r => r.Name == "Volvo");
            var audi = dbContext.Manufacturers.First(r => r.Name == "Audi");
            var bmw = dbContext.Manufacturers.First(r => r.Name == "BMW");
            var volkswagen = dbContext.Manufacturers.First(r => r.Name == "Volkswagen");
            var saab = dbContext.Manufacturers.First(r => r.Name == "Saab");
            if (!dbContext.Cars.Any(r=>r.RegNumber == "BBB111"))
            {
                
                    dbContext.Cars.Add(new Bil
                    {
                        RegNumber = "BBB111",
                        Manufacturer = volvo,
                        Model = "XC60",
                        Price = 12000,
                        Year = 1973
                    });
            }
            if (!dbContext.Cars.Any(r => r.RegNumber == "BDC234"))
            {

                dbContext.Cars.Add(new Bil
                {
                    RegNumber = "BDC234",
                    Manufacturer = audi,
                    Model = "R8",
                    Price = 700000,
                    Year = 2018
                });
            }
            if (!dbContext.Cars.Any(r => r.RegNumber == "CDE345"))
            {

                dbContext.Cars.Add(new Bil
                {
                    RegNumber = "CDE345",
                    Manufacturer = bmw,
                    Model = "I3",
                    Price = 70000,
                    Year = 2013
                });
            }
            if (!dbContext.Cars.Any(r => r.RegNumber == "DEF456"))
            {

                dbContext.Cars.Add(new Bil
                {
                    RegNumber = "DEF456",
                    Manufacturer = volkswagen,
                    Model = "Passat",
                    Price = 50000,
                    Year = 2007
                });
            }
            if (!dbContext.Cars.Any(r => r.RegNumber == "EFG567"))
            {

                dbContext.Cars.Add(new Bil
                {
                    RegNumber = "EFG567",
                    Manufacturer = saab,
                    Model = "95",
                    Price = 1000,
                    Year = 2006
                });
            }
            dbContext.SaveChanges();
        }
        private static void SeedLastbil(ApplicationDbContext dbContext)
        {
            var volvo = dbContext.Manufacturers.First(r => r.Name == "Volvo");
            var scania = dbContext.Manufacturers.First(r => r.Name == "Scania");
            var mercedes = dbContext.Manufacturers.First(r => r.Name == "Mercedes");
            if (!dbContext.Trucks.Any(r=>r.RegNumber == "HEJ123"))
            {
                dbContext.Trucks.Add(new Lastbil
                {
                    RegNumber = "HEJ123",
                    Manufacturer = volvo,
                    LoadVolumeKvm = 15
                });
            }
            if (!dbContext.Trucks.Any(r => r.RegNumber == "FGH678"))
            {
                dbContext.Trucks.Add(new Lastbil
                {
                    RegNumber = "FGH678",
                    Manufacturer = scania,
                    LoadVolumeKvm = 17
                });
            }
            if (!dbContext.Trucks.Any(r => r.RegNumber == "GHI789"))
            {
                dbContext.Trucks.Add(new Lastbil
                {
                    RegNumber = "GHI789",
                    Manufacturer = mercedes,
                    LoadVolumeKvm = 20
                });
            }
            dbContext.SaveChanges();
        }
    }
}
