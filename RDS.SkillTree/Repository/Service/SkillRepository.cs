using RDS.SkillTree.Models;
using RDS.SkillTree.Repository.Interface;

namespace RDS.SkillTree.Repository.Service
{
    public class SkillRepository : ISkillRepository
    {
        public List<Skill> GetAll()
        {
            return mockData();
        }


        public List<Skill> mockData()
        {


            return new List<Skill>()
            {
                new Skill()
                {
                    IsDeleted = false,
                    Id = 1,
                    CreatedAt = DateTime.Now,
                    CreatedBy="migration user",
                    Name= "Test",
                    SkillType="Atomic",
                    UpdatedBy="N/A",
                    UpdatedAt= DateTime.Now,
                },new Skill()
                {
                    IsDeleted = false,
                    Id = 2,
                    CreatedAt = DateTime.Now,
                    CreatedBy="migration user",
                    Name= "Test1",
                    SkillType="Atomic",
                    UpdatedBy="N/A",
                    UpdatedAt= DateTime.Now,
                }
            };
        }
    }
}
