namespace RDS.SkillTree.Models;

public partial class UserSkill
{
    public string UserId { get; set; } = null!;

    public int SkillId { get; set; }

    public virtual Skill Skill { get; set; } = null!;
}
