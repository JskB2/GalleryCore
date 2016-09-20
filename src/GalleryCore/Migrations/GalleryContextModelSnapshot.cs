using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GalleryCore.Models.Entities;

namespace GalleryCore.Migrations
{
    [DbContext(typeof(GalleryContext))]
    partial class GalleryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GalleryCore.Models.Entities.Comment", b =>
                {
                    b.Property<int>("IDComment")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 500);

                    b.Property<int>("GalleryPicID");

                    b.HasKey("IDComment");

                    b.HasIndex("GalleryPicID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GalleryCore.Models.Entities.GalleryPic", b =>
                {
                    b.Property<int>("IDPic")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<DateTime>("UploadDate");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("IDPic");

                    b.ToTable("GalleryPics");
                });

            modelBuilder.Entity("GalleryCore.Models.Entities.Comment", b =>
                {
                    b.HasOne("GalleryCore.Models.Entities.GalleryPic", "GalleryPic")
                        .WithMany("Comments")
                        .HasForeignKey("GalleryPicID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
