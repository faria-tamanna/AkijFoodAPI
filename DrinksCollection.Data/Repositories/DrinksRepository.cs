using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksCollection.Data.Interfaces;
using DrinksCollection.Data.Models;

namespace DrinksCollection.Data.Repositories
{
    public class DrinksRepository : Interfaces.IDrinksRepository
    {
        public List<ColdDrinks> drinks = new List<ColdDrinks>()
        {
            new ColdDrinks {Id = 1, Name = "Clemon", Quantity = 450, Price = 20},
            new ColdDrinks {Id = 2, Name = "Frutika", Quantity = 500, Price = 25},
            new ColdDrinks {Id = 3, Name = "Speed", Quantity = 600, Price = 30}
        };

        public List<ColdDrinks> GetAllDrinks()
        {
            return drinks;
        }

        public ColdDrinks GetDrinks(int id)
        {
            return drinks.FirstOrDefault(x => x.Id == id);
        }
    }
}
