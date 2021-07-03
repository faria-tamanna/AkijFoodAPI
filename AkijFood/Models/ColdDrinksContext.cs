using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AkijFood.Models
{
    public class ColdDrinksContext : DbContext
    {
        public ColdDrinksContext(DbContextOptions<ColdDrinksContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<ColdDrinks> drinks { get; set; }
    }
}
