using Microsoft.AspNetCore.Mvc;
using RDS.SkillTree.Models;
using RDS.SkillTree.Services.Interface;

namespace RDS.SkillTree.Controllers
{
    [Route("User/")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet(Name = "GetUserById")]
        [ProducesDefaultResponseType(typeof(List<Skill>))]
        public async Task<IActionResult> GetUserById(int Id)
        {
            var res = _userService.GetUserById(Id);
            if (res == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(res);
            }
        }
    }
}
