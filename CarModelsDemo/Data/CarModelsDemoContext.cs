using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarModelsDemo.Models;

namespace CarModelsDemo.Data
{
    public class CarModelsDemoContext : DbContext
    {
        public CarModelsDemoContext (DbContextOptions<CarModelsDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CarModelsDemo.Models.CarModelsLogic> CarModelsLogics { get; set; }
    }
}
