namespace RDS.SkillTree.Models;

public partial class User
{
    public int Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string FirstName { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string? LastName { get; set; }

    public string? RdsUserId { get; set; }

    public string UserRole { get; set; } = null!;

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public byte? UserType { get; set; }

    public virtual ICollection<EndorsementList> EndorsementLists { get; set; } = new List<EndorsementList>();

    public virtual ICollection<Endorsement> Endorsements { get; set; } = new List<Endorsement>();
}
