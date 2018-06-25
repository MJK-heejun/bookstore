using bookstore.Dto;
using bookstore.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IConfiguration _configuration;
        public UsersController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        
        //this was implemented, but did not end up being used....
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserDto userDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            string hashedPass = AuthHelper.ConvertToHashedString(userDto.password);
            var result = _context.Users
                .Where(u => u.username == userDto.username && u.password == hashedPass)
                .FirstOrDefault();

            if (result != null)
            {
                result.token = AuthHelper.CreateToken(99);
                await _context.SaveChangesAsync();
                return Ok(new { username = result.username, token = result.token });
            }
            return BadRequest("invalid login");
        }
        
    }

}