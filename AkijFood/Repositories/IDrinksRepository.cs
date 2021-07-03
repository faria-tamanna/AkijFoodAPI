using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AkijFood.Models;

namespace AkijFood.Repositories
{
    public interface IDrinksRepository
    {
        Task<IEnumerable<ColdDrinks>> Get();
        Task<ColdDrinks> Get(int id);
        Task<ColdDrinks> Create(ColdDrinks coldDrinks);
        Task Update(ColdDrinks coldDrinks);
        Task Delete(int id);

    }
}
