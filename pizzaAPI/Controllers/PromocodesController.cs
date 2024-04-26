

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pizzaAPI.Models;

namespace pizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocodesController : ControllerBase
    {
        private readonly PizzasDbContext _context;

        public PromocodesController(PizzasDbContext context)
        {
             _context = context;
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> GetPromocodes()
        {
            return Ok(await _context.Promocodes.ToListAsync());
        }
        
        [HttpGet("{promocode}"), Authorize]
        public async Task<IActionResult> CheckPromocode(string promocode)
        {
            var promo = await _context.Promocodes.FirstOrDefaultAsync(p => p.Promocode1 == promocode);
            if (promo == null)
            {
                return Ok(0);
            }
            
                return Ok( promo.PercentageDiscount);
            
        }
    }
}
