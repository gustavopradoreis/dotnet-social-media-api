// <auto-generated />
using System;
using Posterr.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Posterr.Infrastructure.Data.Migrations
{
    [DbContext(typeof(PosterrContext))]
    partial class PosterrContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

#pragma warning restore 612, 618
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
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValue(null);

                b.Property<Guid>("RepostId")
                    .HasColumnType("uniqueidentifier")
                    .HasDefaultValue(null);

                b.Property<string>("Created")
                    .HasColumnType("nvarchar(50)");

                b.HasKey("Id");

                b.HasIndex("RepostId");

                b.HasIndex("UserName");

                b.ToTable("Posts");
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

                b.HasIndex("UserName");

                b.ToTable("Users");
            });
        }
    }
}
