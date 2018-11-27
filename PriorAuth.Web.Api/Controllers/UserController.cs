using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using PriorAuth.Web.Data;
using PriorAuth.Web.Services.Interfaces;

namespace PriorAuth.Web.Api.Controllers
{
    /// <summary>
    /// User Controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// Inject services required for user controller
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Get a list of all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var retVal = await _userService.GetAllUsers();

            return Ok(retVal);
        }
        
        /// <summary>
        /// Get single user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var retVal = await _userService.GetUserById(id);

            return Ok(retVal);
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            var retVal = await _userService.CreateUser(user);

            return Ok(retVal);
        }

        /// <summary>
        /// Update an existing user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] User user)
        {
            var retVal = await _userService.UpdateUser(user);

            return Ok(retVal);
        }
    }
}
