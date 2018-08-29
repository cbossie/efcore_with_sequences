using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreSequence.EF
{
    public partial class UserContext : DbContext
    {
        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<RoleAttribute> RoleAttributes {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQL2016;Database=SEQUENCE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define sequences for creation
            modelBuilder.HasSequence("UserRoleIDs").IncrementsBy(2).StartsAt(5000);
            modelBuilder.HasSequence("roleAttributeIds").IncrementsBy(14).StartsAt(19777);

            // All tables without identity will use this sequence
            modelBuilder.ForSqlServerUseSequenceHiLo("AllIDs");

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(a => a.UserId).HasName("PK_UserId");
                
                
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                // Primary key for non-identity column
                entity.Property(a => a.RoleId).HasDefaultValueSql("NEXT VALUE FOR dbo.UserRoleIDs");
                entity.HasKey(a => a.RoleId).HasName("PK_RoleId");                
                entity.HasOne(a => a.User)
                    .WithMany(a => a.UserRoles)
                    .HasForeignKey(a => a.UserId)
                    .HasConstraintName("FK_UserRole_User");
            });


            modelBuilder.Entity<RoleAttribute>(entity => {
                // Primary key for non-identity column
                entity.Property(a => a.RoleAttributeId).HasDefaultValueSql("NEXT VALUE FOR dbo.roleAttributeIds");
                // Same value will be generated for this column too - that is a property of sequences
                entity.Property(a => a.Seq).IsRequired().HasDefaultValueSql("NEXT VALUE FOR dbo.roleAttributeIds");
                entity.HasKey(a => a.RoleAttributeId).HasName("PK_UserRoles");
                entity.HasOne(a => a.Role)
                    .WithMany(a => a.Attributes)
                    .HasForeignKey(a => a.UserRoleId)
                    .HasConstraintName("FK_UserRoles_RoleAttributes");
            });


        }
    }
}