using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using RDS.SkillTree.Models;
using RDS.SkillTree.Services.Interface;
using System.Net;

namespace RDS.SkillTree.Controllers
{
    [Route("Skills/")]
    [ApiController]
    public class EndrocementController : ControllerBase
    {
        private readonly ISkillService _skillService;
        public EndrocementController(ISkillService skillService)
        {
            _skillService = skillService;
        }
        [HttpGet(Name = "GetSkills")]
        [ProducesDefaultResponseType(typeof(List<Skill>))]
        public async Task<IActionResult> GetAllSkills()
        {
            var res = _skillService.GetSkills();
            if (res == null)
            {
                return NoContent();
            }
            else
            {
                return Ok(res);
            }
        }

        [HttpGet]
        [Route("GetAllSkillById")]
        [ProducesDefaultResponseType(typeof(Skill))]
        public ActionResult<Skill> GetAllSkillById(int Id, bool includeDeleted)
        {
            var res = _skillService.GetSkillsById(Id);
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
