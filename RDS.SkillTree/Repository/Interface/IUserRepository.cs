﻿using RDS.SkillTree.Models;

namespace RDS.SkillTree.Repository.Interface
{
    public interface IUserRepository
    {
        public User GetUserById(int Id);
    }
}
