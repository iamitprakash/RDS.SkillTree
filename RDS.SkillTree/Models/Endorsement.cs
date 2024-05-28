namespace RDS.SkillTree.Models;

public partial class Endorsement
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string EndorsementStatus { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? SkillId { get; set; }

    public int? UserId { get; set; }

    public virtual ICollection<EndorsementList> EndorsementLists { get; set; } = new List<EndorsementList>();

    public virtual Skill? Skill { get; set; }

    public virtual User? User { get; set; }
}
