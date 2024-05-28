namespace RDS.SkillTree.Models;

public partial class EndorsementList
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public int? EndorsementId { get; set; }

    public int? UserId { get; set; }

    public virtual Endorsement? Endorsement { get; set; }

    public virtual User? User { get; set; }
}
