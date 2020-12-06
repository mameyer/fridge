using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using fridge.Models;

namespace fridge.Controllers.api
{
    public class FoodApiController : Controller
    {
        public FoodApiController()
            : base()
        {
        }

        public async Task<IEnumerable<Food>> Get()
        {
            var food = new Food[]
            {
                new Food { Id = 0, Name = "Fisch" },
                new Food { Id = 1, Name = "Gemuese" }
            };

            return food;
        }
    }
}