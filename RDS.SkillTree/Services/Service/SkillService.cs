using RDS.SkillTree.Models;
using RDS.SkillTree.Repository.Interface;
using RDS.SkillTree.Services.Interface;

namespace RDS.SkillTree.Services.Repository
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skillRepository;

        public SkillService(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;       
        }
        public List<Skill> GetSkills()
        {
            return  _skillRepository.GetAll();
        }
    }
}
