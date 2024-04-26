using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UserController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("UserId")]
        public async Task<ActionResult<string>> GetUserId()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                return Ok(user.Id);
            }
            
            return NotFound();
        }
    }
}