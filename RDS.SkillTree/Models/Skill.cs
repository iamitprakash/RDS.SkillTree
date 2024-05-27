using System;
using System.Collections.Generic;

namespace RDS.SkillTree.Models;

public partial class Skill
{
    public int Id { get; set; } 

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string Name { get; set; } = null!;

    public string SkillType { get; set; } = null!;

    public string CreatedBy { get; set; }

    public string  UpdatedBy { get; set; }

   
}
