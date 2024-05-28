using RDS.SkillTree.Models;
using RDS.SkillTree.Repository.Interface;

namespace RDS.SkillTree.Repository.Service
{
    public class UserRepository : IUserRepository
    {
        public User GetUserById(int Id)
        {
            return new User
            {
                Id = Id,
                FirstName = "test name",
                LastName="last name",
                CreatedAt = DateTime.Now,
                CreatedBy="migration user",
                UpdatedAt = DateTime.Now,
            };
        }
    }
}
