﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Data;

namespace Project1.Migrations
{
    [DbContext(typeof(CasaContext))]
    partial class CasaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project1.Models.Adresa", b =>
                {
                    b.Property<int>("AdresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdresaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.HasKey("AdresaId");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("Project1.Models.Casa", b =>
                {
                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<string>("Nume")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CasaId");

                    b.ToTable("Casa");
                });

            modelBuilder.Entity("Project1.Models.Rol", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Project1.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CasaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CasaId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project1.Models.UserRol", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasAlternateKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Project1.Models.Casa", b =>
                {
                    b.HasOne("Project1.Models.Adresa", "Adresa")
                        .WithOne("Casa")
                        .HasForeignKey("Project1.Models.Casa", "CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Project1.Models.User", b =>
                {
                    b.HasOne("Project1.Models.Casa", "Casa")
                        .WithMany("Useri")
                        .HasForeignKey("CasaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Casa");
                });

            modelBuilder.Entity("Project1.Models.UserRol", b =>
                {
                    b.HasOne("Project1.Models.Rol", "Rol")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project1.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Project1.Models.Adresa", b =>
                {
                    b.Navigation("Casa");
                });

            modelBuilder.Entity("Project1.Models.Casa", b =>
                {
                    b.Navigation("Useri");
                });

            modelBuilder.Entity("Project1.Models.Rol", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Project1.Models.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
