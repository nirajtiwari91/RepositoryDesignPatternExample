using Microsoft.AspNetCore.Mvc;

namespace DesignPatternExample.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _userService.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.Id }, user);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleted = _userService.DeleteUser(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }

        // Other CRUD operations
    }
}
