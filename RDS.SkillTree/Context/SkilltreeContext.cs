using System;
using System.Collections.Generic;
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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=skilltree;Trusted_Connection=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Endorsement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__endorsem__3213E83FBFAB00AF");

            entity.ToTable("endorsements");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("created_by");
            entity.Property(e => e.EndorsementStatus)
                .HasMaxLength(20)
                .HasDefaultValue("APPROVED")
                .HasColumnName("endorsement_status");
            entity.Property(e => e.SkillId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("skill_id");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("user_id");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EndorsementCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FK3sf16mlcqdyg1onb1jc6mxeio");

            //entity.HasOne(d => d.Skill).WithMany(p => p.Endorsements)
            //    .HasForeignKey(d => d.SkillId)
            //    .HasConstraintName("FKjuhgii7d9bdgjke3oj23bekjr");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.EndorsementUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FK6emgcd942r9a82xxexnqnylq1");

            entity.HasOne(d => d.User).WithMany(p => p.EndorsementUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FKqifr4ov88b3t52y9y0ulyuk84");
        });

        modelBuilder.Entity<EndorsementList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__endorsem__3213E83FDF56FEE1");

            entity.ToTable("endorsement_list");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("description");
            entity.Property(e => e.EndorsementId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
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
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("updated_by");
            entity.Property(e => e.UserId)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("user_id");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EndorsementListCreatedByNavigations)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FKqqxe0t3a2s23kgb2f48holnkk");

            entity.HasOne(d => d.Endorsement).WithMany(p => p.EndorsementLists)
                .HasForeignKey(d => d.EndorsementId)
                .HasConstraintName("FK1b6wybyeg8g4h5ov6pku3or7x");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.EndorsementListUpdatedByNavigations)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FKpegfdaa9fjc38wu10554ib3bj");

            entity.HasOne(d => d.User).WithMany(p => p.EndorsementListUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FKr2uc9u9bi64lae1hiy61v206h");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__skill__3213E83F35D5BCC5");

            entity.ToTable("skill");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
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
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("updated_by");

            //entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.SkillCreatedByNavigations)
            //    .HasForeignKey(d => d.CreatedBy)
            //    .HasConstraintName("FKk9ihlls00bo5ljvdgnsgf7r5w");

            //entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.SkillUpdatedByNavigations)
            //    .HasForeignKey(d => d.UpdatedBy)
            //    .HasConstraintName("FKga0cp46ei9oe50sknbkty2xh7");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__users__3213E83F7D237EA4");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasMaxLength(16)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
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
                .HasMaxLength(16)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("updated_by");
            entity.Property(e => e.UserRole)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("MAVEN")
                .HasColumnName("user_role");
            entity.Property(e => e.UserType)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("user_type");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.InverseCreatedByNavigation)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("FKibk1e3kaxy5sfyeekp8hbhnim");

            entity.HasOne(d => d.UpdatedByNavigation).WithMany(p => p.InverseUpdatedByNavigation)
                .HasForeignKey(d => d.UpdatedBy)
                .HasConstraintName("FKci7xr690rvyv3bnfappbyh8x0");

            //entity.HasMany(d => d.Skills).WithMany(p => p.Users)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "UserSkill",
            //        r => r.HasOne<Skill>().WithMany()
            //            .HasForeignKey("SkillId")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FKj53flyds4vknyh8llw5d7jdop"),
            //        l => l.HasOne<User>().WithMany()
            //            .HasForeignKey("UserId")
            //            .OnDelete(DeleteBehavior.ClientSetNull)
            //            .HasConstraintName("FKc2o84wspod5se9pa8lxmhig0q"),
            //        j =>
            //        {
            //            j.HasKey("UserId", "SkillId").HasName("PK__user_ski__36059F3886DEC3C5");
            //            j.ToTable("user_skill");
            //            j.IndexerProperty<byte[]>("UserId")
            //                .HasMaxLength(16)
            //                .IsFixedLength()
            //                .HasColumnName("user_id");
            //            j.IndexerProperty<byte[]>("SkillId")
            //                .HasMaxLength(16)
            //                .IsFixedLength()
            //                .HasColumnName("skill_id");
            //        });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
