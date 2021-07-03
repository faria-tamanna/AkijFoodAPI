using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksCollection.Data.Models;

namespace DrinksCollection.Data.Interfaces
{
    public interface IDrinksRepository
    {
        List<ColdDrinks> GetAllDrinks();
        ColdDrinks GetDrinks(int id);
    }
}
