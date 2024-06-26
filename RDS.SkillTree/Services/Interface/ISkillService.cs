﻿using RDS.SkillTree.Models;

namespace RDS.SkillTree.Services.Interface
{
    public interface ISkillService
    {
        public List<Skill> GetSkills();
        public Skill GetSkillsById(int Id);
    }
}
