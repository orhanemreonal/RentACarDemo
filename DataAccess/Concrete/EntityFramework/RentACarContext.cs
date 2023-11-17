using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RentACar;Trusted_Connection=true");
                // DESKTOP-OIF782Q
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Body>  Bodies { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<Gear> Gears { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
