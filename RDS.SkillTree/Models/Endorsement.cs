using System;
using System.Collections.Generic;

namespace RDS.SkillTree.Models;

public partial class Endorsement
{
    public byte[] Id { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string EndorsementStatus { get; set; } = null!;

    public byte[]? CreatedBy { get; set; }

    public byte[]? UpdatedBy { get; set; }

    public byte[]? SkillId { get; set; }

    public byte[]? UserId { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<EndorsementList> EndorsementLists { get; set; } = new List<EndorsementList>();

    public virtual Skill? Skill { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual User? User { get; set; }
}
