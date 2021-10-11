using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace InterviewProj.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Claim> Claims { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<FileActivityLink> FileActivityLinks { get; set; }
        public virtual DbSet<LegacyActivity> LegacyActivities { get; set; }
        public virtual DbSet<LegacyActivityCategory> LegacyActivityCategories { get; set; }
        public virtual DbSet<LegacyActivityType> LegacyActivityTypes { get; set; }
        public virtual DbSet<LossType> LossTypes { get; set; }
        public virtual DbSet<PartyClaimRole> PartyClaimRoles { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartyType)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Claim>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Created)
                    .WithMany()
                    .HasForeignKey(d => d.CreatedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Claims__CreatedI__10416098");

                entity.HasOne(d => d.LastUpdated)
                    .WithMany()
                    .HasForeignKey(d => d.LastUpdatedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Claims__LastUpda__113584D1");

                entity.HasOne(d => d.LossAdjuster)
                    .WithMany()
                    .HasForeignKey(d => d.LossAdjusterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Claims__LossAdju__0F4D3C5F");

                entity.HasOne(d => d.LossType)
                    .WithMany()
                    .HasForeignKey(d => d.LossTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Claims__LossType__0E591826");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PartyTypeCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RecipientTo).IsUnicode(false);

                entity.Property(e => e.SentBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Subject).IsUnicode(false);
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PublicId).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<FileActivityLink>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LegacyActivity>(entity =>
            {
                entity.Property(e => e.ActivityDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AdhocOrPartyInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CategoryInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Detail).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TypeCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LegacyActivityCategory>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LegacyActivityType>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CategoryCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LossType>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LossTypeCode).IsUnicode(false);

                entity.Property(e => e.LossTypeDescription).IsUnicode(false);
            });

            modelBuilder.Entity<PartyClaimRole>(entity =>
            {
                entity.Property(e => e.AdhocOrPartyInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ContactName).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartyTypeCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<PartyType>(entity =>
            {
                entity.Property(e => e.Active)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Code)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastUpdatedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.DisplayName).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
