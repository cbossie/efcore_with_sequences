﻿// <auto-generated />
using EFCoreSequence.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreSequence.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20180829151117_Another3")]
    partial class Another3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.AllIDs", "'AllIDs', '', '1', '10', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.roleAttributeIds", "'roleAttributeIds', '', '5000', '14', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.UserRoleIDs", "'UserRoleIDs', '', '5000', '2', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:HiLoSequenceName", "AllIDs")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

            modelBuilder.Entity("EFCoreSequence.EF.RoleAttribute", b =>
                {
                    b.Property<int>("RoleAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("Attribute");

                    b.Property<int>("Seq")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.roleAttributeIds");

                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.roleAttributeIds");

                    b.Property<string>("Value");

                    b.HasKey("RoleAttributeId")
                        .HasName("PK_UserRoles");

                    b.HasIndex("UserRoleId");

                    b.ToTable("RoleAttributes");
                });

            modelBuilder.Entity("EFCoreSequence.EF.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId")
                        .HasName("PK_UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("EFCoreSequence.EF.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR dbo.UserRoleIDs");

                    b.Property<string>("RoleName");

                    b.Property<int>("UserId");

                    b.HasKey("RoleId")
                        .HasName("PK_RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("EFCoreSequence.EF.RoleAttribute", b =>
                {
                    b.HasOne("EFCoreSequence.EF.UserRole", "Role")
                        .WithMany("Attributes")
                        .HasForeignKey("UserRoleId")
                        .HasConstraintName("FK_UserRoles_RoleAttributes")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFCoreSequence.EF.UserRole", b =>
                {
                    b.HasOne("EFCoreSequence.EF.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UserRole_User")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
