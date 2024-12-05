﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaginaIst.Data;

#nullable disable

namespace PaginaIst.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PaginaIst.Models.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Area");
                });

            modelBuilder.Entity("PaginaIst.Models.Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ruta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Documento");
                });

            modelBuilder.Entity("PaginaIst.Models.Empleados", b =>
                {
                    b.Property<string>("cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha_Ingreso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fecha_Salida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id_Salario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cedula");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("PaginaIst.Models.Equipo", b =>
                {
                    b.Property<int>("PLACA")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PLACA"));

                    b.Property<string>("CAPACIDAD_DISCO_No1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CAPACIDAD_DISCO_No2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CAPACIDAD_FUENTE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLASE_DE_DISCO_No1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CLASE_DE_DISCO_No2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FECHA_FIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FECHA_INICIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FUENTE_Y_DEMAS_ACCESORIOS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GARANTIA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HOSTNAME")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_EMPLEADO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ID_TIPOEQUIPO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MARCA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEMORIA_RAM_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MEMORIA_RAM_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MODELO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIT_PROVEEDOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PROCESADOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SERIAL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VIDA_UTIL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PLACA");

                    b.ToTable("Equipo");
                });

            modelBuilder.Entity("PaginaIst.Models.Equipo_Software", b =>
                {
                    b.Property<int>("ID_EQÚIPO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_EQÚIPO"));

                    b.Property<int>("ID_SOFTWARE")
                        .HasColumnType("int");

                    b.HasKey("ID_EQÚIPO");

                    b.ToTable("Equipo_Software");
                });

            modelBuilder.Entity("PaginaIst.Models.Historia_Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("FECHA_INGRESO")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FECHA_RETIRO")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_EMPLEADO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Historia_Empleado");
                });

            modelBuilder.Entity("PaginaIst.Models.Historia_Mantenimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Fecha_MTTO")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_MTTO_FUTURO")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_EQUIPO")
                        .HasColumnType("int");

                    b.Property<int>("ID_MTTO")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Historia_Mantenimientos");
                });

            modelBuilder.Entity("PaginaIst.Models.Historia_Salario", b =>
                {
                    b.Property<int>("ID_EMPLEADO")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_EMPLEADO"));

                    b.Property<DateTime?>("FECHA_FIN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FECHA_INICIO")
                        .HasColumnType("datetime2");

                    b.Property<string>("SALARIO")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_EMPLEADO");

                    b.ToTable("Historia_Salario");
                });

            modelBuilder.Entity("PaginaIst.Models.Mantenimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ruta_evidencias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mantenimiento");
                });

            modelBuilder.Entity("PaginaIst.Models.PaginasIst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaginasIst");
                });

            modelBuilder.Entity("PaginaIst.Models.Proveedores", b =>
                {
                    b.Property<int>("NIT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NIT"));

                    b.Property<string>("DIRECCION")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FECHA_FIN")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FECHA_INICIO")
                        .HasColumnType("datetime2");

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIT");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("PaginaIst.Models.Recursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("PaginaIst.Models.Software", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("FECHA_COMPRA")
                        .HasColumnType("datetime2");

                    b.Property<string>("ID_TIPO_SOFTWARE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LLAVE_LICENCIA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIT_PROVEEDOR")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Software");
                });

            modelBuilder.Entity("PaginaIst.Models.Tipo_Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Equipo");
                });

            modelBuilder.Entity("PaginaIst.Models.Tipo_Mantenimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Mantenimiento");
                });

            modelBuilder.Entity("PaginaIst.Models.Tipo_Software", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("NOMBRE")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipo_Software");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
