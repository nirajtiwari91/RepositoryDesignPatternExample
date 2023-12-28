
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternExample.Controllers
{
    [Route("user")]
    [ApiController]
    
    public class UserRepositoryController : ControllerBase
    {
        private readonly UserServiceRepository _userServiceRepository;

        public UserRepositoryController(UserServiceRepository userServiceRepository)
        {
            _userServiceRepository = userServiceRepository;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userServiceRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(int id)
        {
            var user = _userServiceRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserRepositoryModel userRepositoryModel)
        {
            _userServiceRepository.AddUser(userRepositoryModel);
            return CreatedAtAction(nameof(GetUserById), new { id = userRepositoryModel.Id}, userRepositoryModel);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var deleted = _userServiceRepository.DeleteUser(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }

        // Other CRUD operations
    }
}
