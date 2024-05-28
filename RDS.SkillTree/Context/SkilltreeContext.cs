using Microsoft.EntityFrameworkCore;
using RDS.SkillTree.Models;

namespace RDS.SkillTree.Context;

public partial class SkilltreeContext : DbContext
{
    public SkilltreeContext()
    {
    }

    public SkilltreeContext(DbContextOptions<SkilltreeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Endorsement> Endorsements { get; set; }

    public virtual DbSet<EndorsementList> EndorsementLists { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserSkill> UserSkills { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=skilltree;Trusted_Connection=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Endorsement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__endorsem__3213E83FA8FA3A10");

            entity.ToTable("endorsements");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("created_by");
            entity.Property(e => e.EndorsementStatus)
                .HasMaxLength(20)
                .HasDefaultValue("APPROVED")
                .HasColumnName("endorsement_status");
            entity.Property(e => e.SkillId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Skill).WithMany(p => p.Endorsements)
                .HasForeignKey(d => d.SkillId)
                .HasConstraintName("FKjuhgii7d9bdgjke3oj23bekjr");

            entity.HasOne(d => d.User).WithMany(p => p.Endorsements)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FKqifr4ov88b3t52y9y0ulyuk84");
        });

        modelBuilder.Entity<EndorsementList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__endorsem__3213E83F67039535");

            entity.ToTable("endorsement_list");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("description");
            entity.Property(e => e.EndorsementId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("endorsement_id");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(true)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .HasDefaultValue("NEGATIVE")
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Endorsement).WithMany(p => p.EndorsementLists)
                .HasForeignKey(d => d.EndorsementId)
                .HasConstraintName("FK1b6wybyeg8g4h5ov6pku3or7x");

            entity.HasOne(d => d.User).WithMany(p => p.EndorsementLists)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FKr2uc9u9bi64lae1hiy61v206h");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__skill__3213E83FCDB10A78");

            entity.ToTable("skill");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("created_by");
            entity.Property(e => e.IsDeleted)
                .HasDefaultValue(true)
                .HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.SkillType)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("ATOMIC")
                .HasColumnName("skill_type");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("updated_by");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F8BAACFC1");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("created_by");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("image_url");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("last_name");
            entity.Property(e => e.RdsUserId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("rds_user_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("updated_by");
            entity.Property(e => e.UserRole)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("MAVEN")
                .HasColumnName("user_role");
            entity.Property(e => e.UserType)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<UserSkill>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.SkillId }).HasName("PK__user_ski__36059F38075C58F3");

            entity.ToTable("user_skill");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("user_id");
            entity.Property(e => e.SkillId).HasColumnName("skill_id");

            entity.HasOne(d => d.Skill).WithMany(p => p.UserSkills)
                .HasForeignKey(d => d.SkillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKj53flyds4vknyh8llw5d7jdop");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
