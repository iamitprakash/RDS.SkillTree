using System;
using System.Collections.Generic;

namespace RDS.SkillTree.Models;

public partial class Skill
{
    public byte[] Id { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool IsDeleted { get; set; }

    public string Name { get; set; } = null!;

    public string SkillType { get; set; } = null!;

    public byte[]? CreatedBy { get; set; }

    public byte[]? UpdatedBy { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Endorsement> Endorsements { get; set; } = new List<Endorsement>();

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
