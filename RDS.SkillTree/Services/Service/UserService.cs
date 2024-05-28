using RDS.SkillTree.Models;
using RDS.SkillTree.Repository.Interface;
using RDS.SkillTree.Services.Interface;

namespace RDS.SkillTree.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
                _userRepository = userRepository;
        }
        public User GetUserById(int Id)
        {
            return _userRepository.GetUserById(Id);
        }
    }
}
