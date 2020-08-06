﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YichenWang.applicaiton.ClientInformationSystem.Infa.Data;

namespace YCW.ClientInfoSystem.Infa.Migrations
{
    [DbContext(typeof(YCWClientInfoSystemDbContext))]
    [Migration("20200806163133_initional")]
    partial class initional
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Clients", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("InteractionsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phones")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("InteractionsId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("InteractionsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("InteractionsId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Interactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<DateTime>("IntDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IntType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)")
                        .HasMaxLength(1);

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Interactions");
                });

            modelBuilder.Entity("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Clients", b =>
                {
                    b.HasOne("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Interactions", "Interactions")
                        .WithMany("Clients")
                        .HasForeignKey("InteractionsId");
                });

            modelBuilder.Entity("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Employees", b =>
                {
                    b.HasOne("YichenWang.applicaiton.ClientInformationSystem.Core.Entities.Interactions", "Interactions")
                        .WithMany("Employees")
                        .HasForeignKey("InteractionsId");
                });
#pragma warning restore 612, 618
        }
    }
}
