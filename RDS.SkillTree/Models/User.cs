using System;
using System.Collections.Generic;

namespace RDS.SkillTree.Models;

public partial class User
{
    public byte[] Id { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string FirstName { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;

    public string? LastName { get; set; }

    public string? RdsUserId { get; set; }

    public string UserRole { get; set; } = null!;

    public byte[]? CreatedBy { get; set; }

    public byte[]? UpdatedBy { get; set; }

    public byte? UserType { get; set; }

    public virtual User? CreatedByNavigation { get; set; }

    public virtual ICollection<Endorsement> EndorsementCreatedByNavigations { get; set; } = new List<Endorsement>();

    public virtual ICollection<EndorsementList> EndorsementListCreatedByNavigations { get; set; } = new List<EndorsementList>();

    public virtual ICollection<EndorsementList> EndorsementListUpdatedByNavigations { get; set; } = new List<EndorsementList>();

    public virtual ICollection<EndorsementList> EndorsementListUsers { get; set; } = new List<EndorsementList>();

    public virtual ICollection<Endorsement> EndorsementUpdatedByNavigations { get; set; } = new List<Endorsement>();

    public virtual ICollection<Endorsement> EndorsementUsers { get; set; } = new List<Endorsement>();

    public virtual ICollection<User> InverseCreatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<User> InverseUpdatedByNavigation { get; set; } = new List<User>();

    public virtual ICollection<Skill> SkillCreatedByNavigations { get; set; } = new List<Skill>();

    public virtual ICollection<Skill> SkillUpdatedByNavigations { get; set; } = new List<Skill>();

    public virtual User? UpdatedByNavigation { get; set; }

    public virtual ICollection<Skill> Skills { get; set; } = new List<Skill>();
}
