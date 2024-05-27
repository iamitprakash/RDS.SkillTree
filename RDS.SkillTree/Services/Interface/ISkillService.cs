using RDS.SkillTree.Models;

namespace RDS.SkillTree.Services.Interface
{
    public interface ISkillService
    {
        public Task<List<Skill>> GetSkills();
    }
}
