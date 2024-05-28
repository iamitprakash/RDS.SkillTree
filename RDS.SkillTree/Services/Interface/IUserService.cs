using RDS.SkillTree.Models;

namespace RDS.SkillTree.Services.Interface
{
    public interface IUserService
    {
        public User GetUserById(int Id);
    }
}
