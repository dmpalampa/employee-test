﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repo;

namespace Repo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211201235418_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city");

                    b.Property<string>("street");

                    b.Property<string>("village");

                    b.Property<string>("zip_code");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DataAccess.Department", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dHead");

                    b.Property<string>("dName");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new { Id = 1L, dHead = "daud", dName = "Security" }
                    );
                });

            modelBuilder.Entity("DataAccess.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("addressId");

                    b.Property<int>("address_id");

                    b.Property<long?>("deptId");

                    b.Property<int>("dept_id");

                    b.Property<string>("email");

                    b.Property<string>("f_name");

                    b.Property<string>("l_name");

                    b.HasKey("Id");

                    b.HasIndex("addressId");

                    b.HasIndex("deptId");

                    b.ToTable("Employee");

                    b.HasData(
                        new { Id = 1L, address_id = 0, dept_id = 0, email = "david@test.com", f_name = "david", l_name = "daud" },
                        new { Id = 2L, address_id = 0, dept_id = 0, email = "mark@test.com", f_name = "john", l_name = "mark" }
                    );
                });

            modelBuilder.Entity("DataAccess.Employee", b =>
                {
                    b.HasOne("DataAccess.Address", "address")
                        .WithMany("Employee")
                        .HasForeignKey("addressId");

                    b.HasOne("DataAccess.Department", "dept")
                        .WithMany("Employee")
                        .HasForeignKey("deptId");
                });
#pragma warning restore 612, 618
        }
    }
}