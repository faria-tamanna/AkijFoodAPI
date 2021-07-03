using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkijFood.Models;
using Microsoft.EntityFrameworkCore;

namespace AkijFood.Repositories
{
    public class DrinksRepositories : IDrinksRepository
    {
        private readonly ColdDrinksContext _context;
        public DrinksRepositories(ColdDrinksContext context)
        {
            _context = context;
        }

        public async Task<ColdDrinks> Create(ColdDrinks coldDrinks)
        {
            _context.drinks.Add(coldDrinks);
            await _context.SaveChangesAsync();
            return coldDrinks;
        }

        public async Task Delete(int id)
        {
            var drinksToDelete = await _context.drinks.FindAsync(id);
            _context.drinks.Remove(drinksToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ColdDrinks>> Get()
        {
            return await _context.drinks.ToListAsync();
        }

        public async Task<ColdDrinks> Get(int id)
        {
            return await _context.drinks.FindAsync(id);
        }


        public async Task Update(ColdDrinks coldDrinks)
        {
            _context.Entry(coldDrinks).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
