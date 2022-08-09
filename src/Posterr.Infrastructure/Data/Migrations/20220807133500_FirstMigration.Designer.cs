﻿// <auto-generated />
using System;
using Posterr.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Posterr.Infrastructure.Data.Migrations
{
    [DbContext(typeof(PosterrContext))]
    [Migration("20220807133500_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Posterr.Domain.Entity.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RepostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Created")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("Posterr.Domain.Entity.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("UserScreenName")
                        .IsRequired()
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("ProfileImageUrl")
                       .HasColumnType("nvarchar(50)")
                       .HasMaxLength(50);

                    b.Property<string>("Created")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Posterr.Domain.Entity.User", b =>
            {
                b.HasData(
                        new
                        {
                            Id = "f9028ad9-c2a6-4467-b739-549a3d8e25eb",
                            UserName = "test1",
                            UserScreenName = "test1",
                            Created = "August 09, 2022"
                        },
                        new
                        {
                            Id = "c9930f0e-e8e3-419b-b7e4-c169f42e6545",
                            UserName = "test2",
                            UserScreenName = "test2",
                            Created = "August 08, 2022"
                        },
                        new
                        {
                            Id = "5fcc945d-6ed2-40b6-bf21-2a090e99588c",
                            UserName = "test3",
                            UserScreenName = "test3",
                            Created = "August 07, 2022"
                        },
                        new
                        {
                            Id = "5a55a21c-2144-432c-943c-6530b0143cac",
                            UserName = "test4",
                            UserScreenName = "test4",
                            Created = "August 06, 2022"
                        }
                );
            });
#pragma warning restore 612, 618
        }
    }
}
