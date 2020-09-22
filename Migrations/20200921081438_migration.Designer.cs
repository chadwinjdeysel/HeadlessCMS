﻿// <auto-generated />
using System;
using ContentManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContentManagementSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200921081438_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("ContentManagementSystem.Models.Content", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Contents")
                        .HasColumnType("text");

                    b.Property<Guid>("FieldId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Index")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("ModelId");

                    b.ToTable("Contents");
                });

            modelBuilder.Entity("ContentManagementSystem.Models.Field", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ModelId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("fieldType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("ContentManagementSystem.Models.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("ContentManagementSystem.Models.Content", b =>
                {
                    b.HasOne("ContentManagementSystem.Models.Field", "Field")
                        .WithMany("Contents")
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContentManagementSystem.Models.Model", "Model")
                        .WithMany("Contents")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ContentManagementSystem.Models.Field", b =>
                {
                    b.HasOne("ContentManagementSystem.Models.Model", "Model")
                        .WithMany("Fields")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}