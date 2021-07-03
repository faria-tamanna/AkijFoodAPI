using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AkijFood.Models;
using DrinksCollection.Data.Models;
using DrinksCollection.Data.Interfaces;
using DrinksCollection.Data.Repositories;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColdDrinksController : ControllerBase
    {
        /*public List<ColdDrinks> drinks = new List<ColdDrinks>()
        {
            new ColdDrinks {Id = 1, Name = "Clemon", Quantity = 450, Price = 20},
            new ColdDrinks {Id = 2, Name = "Frutika", Quantity = 500, Price = 25},
            new ColdDrinks {Id = 3, Name = "Speed", Quantity = 600, Price = 30}
        };*/

        private IDrinksRepository drinks = new DrinksRepository();

        [HttpGet]
        public ActionResult<IEnumerable<ColdDrinks>> GetAllDrinks()
        {
            return drinks.GetAllDrinks();
        }


        [HttpGet("{id}")]
        public ActionResult<ColdDrinks> GetDrinks(int id)
        {
            //var drink = drinks.FirstOrDefault(x => x.Id == id);
            var drink = drinks.GetDrinks(id);
                
            if(drink == null)
            {
                return NotFound();
            }
            return drink;
        }


    }
}
