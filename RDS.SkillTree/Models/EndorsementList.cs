using System;
using System.Collections.Generic;

namespace RDS.SkillTree.Models;

public partial class EndorsementList
{
    public byte[] Id { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string? Description { get; set; }

    public string Type { get; set; } = null!;

    public byte[]? CreatedBy { get; set; }

    public byte[]? UpdatedBy { get; set; }

    public byte[]? EndorsementId { get; set; }

    public byte[]? UserId { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual Endorsement? Endorsement { get; set; }

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual User? User { get; set; }
}
