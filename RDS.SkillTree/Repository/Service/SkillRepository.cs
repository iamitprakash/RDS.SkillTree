using RDS.SkillTree.Models;
using RDS.SkillTree.Repository.Interface;

namespace RDS.SkillTree.Repository.Service
{
    public class SkillRepository : ISkillRepository
    {
        public Task<List<Skill>> GetAll()
        {
          return Task.FromResult(new List<Skill>() { new Skill()
          {
              IsDeleted = false,
          } });
        }
    }
}
