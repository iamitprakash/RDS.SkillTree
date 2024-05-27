using RDS.SkillTree.Models;

namespace RDS.SkillTree.Repository.Interface
{
    public interface ISkillRepository
    {
        public List<Skill> GetAll();
        public Skill GetSkillsById(int Id);
    }
}
