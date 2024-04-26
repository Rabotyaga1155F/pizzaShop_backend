

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pizzaAPI.Models;

namespace pizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzasController : ControllerBase
    {
        private readonly PizzasDbContext _context;
        public PizzasController(PizzasDbContext context) {

            _context = context;
        }


        [HttpGet,Authorize]
        public async Task<IActionResult> GetPizzas()
        {
            return Ok(await _context.Pizzas.ToListAsync());
        }
        
        
        
    }
}

