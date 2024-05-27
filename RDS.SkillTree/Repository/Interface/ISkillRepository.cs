﻿using RDS.SkillTree.Models;

namespace RDS.SkillTree.Repository.Interface
{
    public interface ISkillRepository
    {
        public Task<List<Skill>> GetAll();
    }
}