﻿// <auto-generated />
using BARBERIA.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Barberia.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BARBERIA.Server.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioRolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioRolId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("BARBERIA.Server.Models.UsuarioRol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PermisoParaCrear")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEditar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermisoParaEliminar")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("UsuariosRoles");
                });

            modelBuilder.Entity("BARBERIA.Server.Models.Usuario", b =>
                {
                    b.HasOne("BARBERIA.Server.Models.UsuarioRol", "UsuarioRol")
                        .WithMany()
                        .HasForeignKey("UsuarioRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioRol");
                });
#pragma warning restore 612, 618
        }
    }
}