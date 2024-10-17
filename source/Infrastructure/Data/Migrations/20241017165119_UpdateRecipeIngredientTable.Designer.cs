﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Infrastructure.Data;

#nullable disable

namespace Project.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241017165119_UpdateRecipeIngredientTable")]
    partial class UpdateRecipeIngredientTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project.Domain.Entities.Ingredient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PK_ID_INGREDIENT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_CREATEDAT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("FL_DELETED");

                    b.Property<string>("Measurement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_MEASUREMENT");

                    b.Property<decimal>("MinimumStock")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("NR_MINIMUM_STOCK");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_NAME");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("NR_CURRENT_STOCK");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("NR_UNIT_PRICE");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_UPDATEDAT");

                    b.HasKey("Id");

                    b.ToTable("T_INGREDIENT", (string)null);
                });

            modelBuilder.Entity("Project.Domain.Entities.Recipe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PK_ID_RECIPE");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_DESCRICAO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_NOME");

                    b.HasKey("Id");

                    b.ToTable("T_RECIPE", (string)null);
                });

            modelBuilder.Entity("Project.Domain.Entities.RecipeIngredient", b =>
                {
                    b.Property<Guid>("RecipeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IngredienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("QuantidadeNecessaria")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("NR_QUANTIDADE_NECESSARIA");

                    b.HasKey("RecipeId", "IngredienteId");

                    b.HasIndex("IngredienteId");

                    b.ToTable("T_RECIPE_INGREDIENTES", (string)null);
                });

            modelBuilder.Entity("Project.Domain.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PK_ROLEID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_CREATEDAT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("FL_DELETED");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_NAME");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_UPDATEDAT");

                    b.HasKey("Id");

                    b.ToTable("T_ROLE", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9a"),
                            CreatedAt = new DateTime(2024, 10, 17, 16, 51, 18, 383, DateTimeKind.Utc).AddTicks(2338),
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9b"),
                            CreatedAt = new DateTime(2024, 10, 17, 16, 51, 18, 383, DateTimeKind.Utc).AddTicks(2342),
                            IsDeleted = false,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("Project.Domain.Entities.StockMovement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PK_ID_STOCK_MOVEMENT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_CREATED_AT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_DESCRIPTION");

                    b.Property<Guid>("IngredientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MovementType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_MOVEMENT_TYPE");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("NR_QUANTITY");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("T_STOCK_MOVEMENT", (string)null);
                });

            modelBuilder.Entity("Project.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PK_USERID");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_CREATEDAT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_EMAIL");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_PASSWORD");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("FL_DELETED");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FK_ROLEID");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2")
                        .HasColumnName("DT_UPDATEDAT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TX_USERNAME");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("T_USER", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("b8a0d1e6-f8a4-44bb-82bc-8342cceba977"),
                            CreatedAt = new DateTime(2024, 10, 17, 16, 51, 18, 383, DateTimeKind.Utc).AddTicks(2519),
                            Email = "admin@admin.com",
                            HashedPassword = "$2a$11$j2EXuNjE2IBvkRe62ap9Vuflu1Z1tHCCr.Ts8umKZQ0FPHMIi1PXe",
                            IsDeleted = false,
                            RoleId = new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9a"),
                            Username = "admin"
                        },
                        new
                        {
                            Id = new Guid("1b5e90a4-4901-4f26-a2fe-7ec1db2da30e"),
                            CreatedAt = new DateTime(2024, 10, 17, 16, 51, 18, 536, DateTimeKind.Utc).AddTicks(4257),
                            Email = "user@user.com",
                            HashedPassword = "$2a$11$sEmG6fB3K089tN2h6g0NTO456d9EsIHrcC1km/SdGsZVyXeoV5pS.",
                            IsDeleted = false,
                            RoleId = new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9b"),
                            Username = "user"
                        });
                });

            modelBuilder.Entity("Project.Domain.Entities.RecipeIngredient", b =>
                {
                    b.HasOne("Project.Domain.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_RECIPE_INGREDIENTES_INGREDIENT");

                    b.HasOne("Project.Domain.Entities.Recipe", "Recipe")
                        .WithMany("Ingredientes")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_RECIPE_INGREDIENTES_RECIPE");

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("Project.Domain.Entities.StockMovement", b =>
                {
                    b.HasOne("Project.Domain.Entities.Ingredient", "Ingredient")
                        .WithMany("StockMovements")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Project.Domain.Entities.User", b =>
                {
                    b.HasOne("Project.Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_USER_ROLE");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Project.Domain.Entities.Ingredient", b =>
                {
                    b.Navigation("StockMovements");
                });

            modelBuilder.Entity("Project.Domain.Entities.Recipe", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("Project.Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
